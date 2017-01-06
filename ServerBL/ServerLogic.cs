using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using CommonLib;


namespace ServerBL
{
    public class ServerLogic
    {
        private readonly static object locker = new object();
        private static TcpListener serverListener;
        private static Thread connThread;
        private static Thread listenerThread;        

        public static List<NetworkStream> ClientStreams = new List<NetworkStream>();
        public static List<User> ConnectedUsers = new List<User>();
        public static bool IsManuallyDisconnected;
        public static bool IsServerOnline { get; set; }

        public static event Action OnServerShutDown;
        public static event Action OnWrongSocket;
        public static event Action<Message, NetworkStream> SocketValidation;
        public static event Action<Message, NetworkStream> OnConnection;
        public static event Action<Message, NetworkStream> OnPublicMessage;
        public static event Action<Message, NetworkStream> RequestForUsers;
        public static event Action<Message, NetworkStream, User> OnUserDisconnect;
        public static event Action<Message, NetworkStream> OnPrivateMessage;

        /// <summary>
        /// This method sets up the listener, subscribes to events and activates a connection thread
        /// </summary>
        /// <param name="server"></param>
        public static void BootServer (Server server)
        {
            serverListener = new TcpListener(IPAddress.Parse(server.IpAddress), server.Port);
            IsServerOnline = true;
            SocketValidation += ServerEventHandlers.SocketValidationHandler;
            OnConnection += ServerEventHandlers.ConnectionHandler;
            OnPublicMessage += ServerEventHandlers.PublicMessageHandler;
            RequestForUsers += ServerEventHandlers.RequestUsersHandler;
            OnUserDisconnect += (message, stream, user) => ServerEventHandlers.UserRegularDisconnectHandler(message, user);
            OnPrivateMessage += ServerEventHandlers.PrivatemessageHandler;
            ServerEventHandlers.OnUnhandledUserDisconnect += (message, stream, index) => ServerEventHandlers.UnhandledDisconnectionHandler(message, index);
            connThread = new Thread(WaitForConnection)
            {IsBackground = true};
            connThread.Start();
        }

        /// <summary>
        /// This method waits for clients and activates a message-listening thread
        /// </summary>
        public static void WaitForConnection ()
        {
            try
            {
                serverListener.Start();
                while (IsServerOnline)
                {
                    if (!IsServerOnline)
                        return;

                    var client = serverListener.AcceptTcpClient();
                    listenerThread = new Thread(() => AcceptMessages(client))
                    {IsBackground = true};
                    listenerThread.Start();
                }
            }
            catch (SocketException)
            {
                if (!IsManuallyDisconnected && IsServerOnline)
                {
                    OnWrongSocket?.Invoke();
                }
                FinalizeConnections();
                IsServerOnline = false;
            }
            catch (Exception)
            {
                FinalizeConnections();
            }
        }

        /// <summary>
        /// This methods manages incoming messages from and to clients , messages are distinguished by tags and are being rerouted to users through events
        /// </summary>
        /// <param name="client"></param>
        private static void AcceptMessages(TcpClient client)
        {
            var formatter = new BinaryFormatter();
            var stream = client.GetStream();
            while (IsServerOnline)
            {
                try
                {
                    while (!stream.DataAvailable)
                    {
                        if (!IsServerOnline)
                            return;
                        Thread.Sleep(100);
                    }
                }
                catch
                {
                    return;
                }
                var message = (Message) formatter.Deserialize(stream);
                switch (message.Tags)
                {
                    case NetworkTags.Validate:
                        SocketValidation?.Invoke(message, stream);
                        message.Tags = NetworkTags.NoTag;
                        break;
                    case NetworkTags.Connect:
                        OnConnection?.Invoke(message, stream);
                        message.Tags = NetworkTags.TcpResponse;
                        OnPublicMessage?.Invoke(message, stream);
                        message.Tags = NetworkTags.NoTag;
                        break;
                    case NetworkTags.Send:
                        OnPublicMessage?.Invoke(message, stream);
                        message.Tags = NetworkTags.NoTag;
                        break;
                    case NetworkTags.SendPrivate:
                        OnPrivateMessage?.Invoke(message, stream);
                        message.Tags = NetworkTags.NoTag;
                        break;
                    case NetworkTags.UserList:
                        RequestForUsers?.Invoke(message, stream);
                        message.Tags = NetworkTags.NoTag;
                        break;
                    case NetworkTags.UserDisconnect:
                        var user = message.User;
                        try
                        {
                            lock (locker)
                            {
                                ClientStreams[message.User.Userid].Close();
                                ClientStreams[message.User.Userid].Dispose();
                            }
                        }
                        catch
                        { }
                        lock (locker)
                        {
                            ConnectedUsers[message.User.Userid] = null;
                            ClientStreams[message.User.Userid] = null; 
                        }
                        OnUserDisconnect?.Invoke(message, stream, user);
                        message.Tags = NetworkTags.NoTag;
                        break;
                    case NetworkTags.NoTag:
                        break;
                }
            }
        }

        /// <summary>
        /// This method empties the stream and sends a disconnect message to the clients
        /// </summary>
        public static void StopListening()
        {
            IsServerOnline = false;
            var disconMessage = new Message
            {
                MessageText = "\n Server is shutting down... \n You were disconnected ",
                Tags = NetworkTags.SeverDisconnect
            };
            NetworkStream stream = null;
            ServerEventHandlers.PublicMessageHandler(disconMessage, stream);
            FinalizeConnections();
        }

        /// <summary>
        /// This method closes all active streams and frees memory resources by disposing and by unsubscribing from events
        /// </summary>
        public static void FinalizeConnections()
        {
            try
            {
                foreach (var stream in ClientStreams)
                {
                    if (stream != null && stream.CanRead)
                    {
                        stream.Close();
                        stream.Dispose();
                    }
                }
            }
            catch
            { }
            try
            {
                OnServerShutDown?.Invoke();
                serverListener.Stop();
                lock (locker)
                {
                    ConnectedUsers.Clear();
                    ClientStreams.Clear(); 
                }
                SocketValidation -= ServerEventHandlers.SocketValidationHandler;
                OnConnection -= ServerEventHandlers.ConnectionHandler;
                OnPublicMessage -= ServerEventHandlers.PublicMessageHandler;
                RequestForUsers -= ServerEventHandlers.RequestUsersHandler;
                OnUserDisconnect -= (message, stream, user) => ServerEventHandlers.UserRegularDisconnectHandler(message, user);
                OnPrivateMessage -= ServerEventHandlers.PrivatemessageHandler;
                ServerEventHandlers.OnUnhandledUserDisconnect -= (message, stream, index) => ServerEventHandlers.UnhandledDisconnectionHandler(message, index);
            }
            catch
            { }
        }
    }
}
