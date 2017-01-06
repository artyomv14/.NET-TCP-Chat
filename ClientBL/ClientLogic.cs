using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using CommonLib;

namespace ClientBL
{
    public class ClientLogic
    {
        private static TcpClient client;
        private static Thread threadListening;

        public static NetworkTags Tags;
        public static bool IsSocketDataValid;
        public static bool IsConnectionDown;
        public static Message MessageData;
        public static List<User> ListOfUsersConnected;
        public static bool IsUserOnline
        { get; set; }
        internal static TcpClient LocalClient
        { get; set; }
        internal static NetworkStream ClientStream
        { get; set; }

        public static event Action<string> NotConnectedToServer;
        public static event Action ServerDisconnected;
        public static event Action<Message> OnMessageReceived;

        /// <summary>
        /// Checks for socket data of the active server and receives a list of connected users to validate a nickname in Registration Form
        /// </summary>
        /// <param name="data"></param>
        public static void SocketDataValidation(Message data)
        {
            using (var userClient = new TcpClient())
            {
                try
                {
                    userClient.Connect(IPAddress.Parse(data.User.IpAddress), data.User.Port);
                    using (var stream = userClient.GetStream())
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(stream, data);
                        var received = (Message)formatter.Deserialize(stream);
                        ListOfUsersConnected = received.ListOfUsers;
                        IsSocketDataValid = true;
                    }
                }
                catch (SocketException)
                {
                    IsSocketDataValid = false;
                    NotConnectedToServer?.Invoke("No server on this socket!");
                }
            }
        }

        /// <summary>
        /// Connection to the active server, sending a user data to the server and awaiting for incoming messages
        /// </summary>
        /// <param name="data"></param>
        /// <param name="user"></param>
        public static void ConnectToServer(Message data, User user)
        {
            try
            {
                //Establishing a connection
                client = new TcpClient();
                var userData = user;
                client.Connect(IPAddress.Parse(data.User.IpAddress), data.User.Port);
                LocalClient = client;
                var formatter = new BinaryFormatter();
                var stream = client.GetStream();
                ClientStream = stream;

                //User socket data provided to the server
                var info = client.Client.LocalEndPoint.ToString();
                char[] socketSeparator = { ':' };
                var socket = info.Split(socketSeparator);
                data.User.IpAddress = socket[0];
                data.User.Port = int.Parse(socket[1]);

                formatter.Serialize(stream, data);
                IsUserOnline = true;
                stream.Flush();
                threadListening = new Thread(() => ListenToMessages(userData))
                {
                    IsBackground = true
                };
                threadListening.Start();
            }
            catch (Exception)
            {
                NotConnectedToServer?.Invoke("Cannot connect to server, server is offline");
                ServerDisconnected?.Invoke();
            }
        }

        /// <summary>
        /// Listening to incoming messages with appropriate tags. The Thread.Sleep method is used to achieve a more balanced CPU workload on slower machines
        /// </summary>
        /// <param name="thisUser"></param>
        private static void ListenToMessages(User thisUser)
        {
            var incomingFormatter = new BinaryFormatter();
            var incomingMessage = new Message();
            var netstream = ClientStream;

            while (IsUserOnline)
            {
                Thread.Sleep(100);
                if (!netstream.CanRead || IsConnectionDown)
                {
                    client.Close();
                    return;
                }
                if (netstream.DataAvailable)
                {
                    incomingMessage = (Message) incomingFormatter.Deserialize(netstream);

                    if (incomingMessage.Tags == NetworkTags.TcpResponse && incomingMessage.User.Username == thisUser.Username)
                    {
                        thisUser.Userid = incomingMessage.User.Userid;
                        OnMessageReceived?.Invoke(incomingMessage);
                    }
                    else if (incomingMessage.Tags == NetworkTags.SeverDisconnect)
                    {
                        OnMessageReceived?.Invoke(incomingMessage);
                        ServerDisconnected?.Invoke();
                        IsUserOnline = false;
                        netstream.Dispose();
                        client.Close();
                    }
                    else
                        OnMessageReceived?.Invoke(incomingMessage);
                }
                incomingMessage.Tags = NetworkTags.NoTag;
            }
        }

        /// <summary>
        /// Sending messages over a stream
        /// </summary>
        /// <param name="outgoing"></param>
        public static void SendMessages(Message outgoing)
        {
            try
            {
                var outgoingFormatter = new BinaryFormatter();
                var netstream = ClientStream;
                if(netstream != null)
                outgoingFormatter.Serialize(netstream, outgoing);
            }
            catch (Exception)
            {
                IsUserOnline = false;
                NotConnectedToServer?.Invoke("The connection to the server was lost!");
                client.Close();
            }
        }

        /// <summary>
        /// Disconnect from the server and send an appropriate Message
        /// </summary>
        /// <param name="userData"></param>
        public static void Disconnect(User userData)
        {
            IsSocketDataValid = false;
            var data = new Message(userData, NetworkTags.UserDisconnect);
            var disconFormatter = new BinaryFormatter();
            var stream = ClientStream;
            try
            {
                if(stream != null)
                disconFormatter.Serialize(stream, data);
            }
            catch
            { }
            try
            {
                ClientStream.Close();
                ClientStream.Dispose();
            }
            finally
            {
                client.Close();
            }
        }
    }
}
