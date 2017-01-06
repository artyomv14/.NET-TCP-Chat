using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using CommonLib;

namespace ServerBL
{
    public class ServerEventHandlers
    {
        private static readonly object locker = new object();
        public static event Action<Message> OnNewUserConnected;
        public static event Action<Message> OnMessageSent;
        public static event Action<User> OnUserRemoval;
        public static event Action<Message, NetworkStream, int> OnUnhandledUserDisconnect;

        internal static void SocketValidationHandler(Message data, NetworkStream stream)
        {
            var formatter = new BinaryFormatter();
            data.ListOfUsers = ServerLogic.ConnectedUsers;
            formatter.Serialize(stream, data);
        }

        internal static void ConnectionHandler(Message message, NetworkStream stream)
        {
            message.User.Userid = ServerLogic.ClientStreams.Count;
            lock (locker)
            {
                ServerLogic.ClientStreams.Add(stream);
                ServerLogic.ConnectedUsers.Add(message.User);
            }
            message.Time = DateTime.Now;
            message.MessageText = message.User.Username + " is connected...";
            OnNewUserConnected?.Invoke(message);
            message.Tags = NetworkTags.TcpResponse;
        }

        internal static void PublicMessageHandler(Message message, NetworkStream stream)
        {
            for (var index = 0; index < ServerLogic.ClientStreams.Count; index++)
            {
                try
                {
                    if (ServerLogic.ClientStreams[index] != null)
                    {
                        var netStream = ServerLogic.ClientStreams[index];
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(netStream, message);
                    }
                }
                catch (IOException)
                {
                    OnUnhandledUserDisconnect?.Invoke(message, stream, index);
                }

            }
            OnMessageSent?.Invoke(message);
        }

        internal static void PrivatemessageHandler(Message message, NetworkStream stream)
        {
            for (var index = 0; index < ServerLogic.ClientStreams.Count; index++)
            {
                try
                {
                    if (ServerLogic.ClientStreams[index] != null && message.PrivMessageUsernames.Contains(ServerLogic.ConnectedUsers[index].Username))
                    {
                        var netStream = ServerLogic.ClientStreams[index];
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(netStream, message);
                    }
                }
                catch (IOException)
                {
                    OnUnhandledUserDisconnect?.Invoke(message, stream, index);
                }
            }
        }

        internal static void RequestUsersHandler(Message data, NetworkStream stream)
        {
            var formatter = new BinaryFormatter();
            lock (locker)
            {
                data.ListOfUsers = new List<User>();
                foreach (var user in ServerLogic.ConnectedUsers)
                {
                    if (user != null)
                        data.ListOfUsers.Add(user);
                } 
            }
            data.Tags = NetworkTags.UserList;
            formatter.Serialize(stream, data);
        }

        internal static void UserRegularDisconnectHandler(Message message, User user)
        {
            for (var index = 0; index < ServerLogic.ClientStreams.Count; index++)
            {
                message.MessageText = message.User.Username + " was disconnected...";
                if (ServerLogic.ClientStreams[index] == null) continue;
                message.Tags = NetworkTags.UserDisconnect;
                var netStream = ServerLogic.ClientStreams[index];
                var discFormatter = new BinaryFormatter();
                discFormatter.Serialize(netStream, message);
            }
            OnUserRemoval?.Invoke(user);
        }

        internal static void UnhandledDisconnectionHandler(Message message, int index)
        {
            message = new Message();
            var disconUser = ServerLogic.ConnectedUsers[index];
            var formatter = new BinaryFormatter();
            try
            {
                ServerLogic.ClientStreams[index].Close();
                ServerLogic.ClientStreams[index].Dispose();
            }
            catch { }

            ServerLogic.ConnectedUsers[index] = null;
            ServerLogic.ClientStreams[index] = null;
            message.MessageText = disconUser.Username + " was disconnected...";
            for (int idx = 0; idx < ServerLogic.ClientStreams.Count; idx++)
            {
                if (ServerLogic.ClientStreams[idx] != null)
                {
                    message.Tags = NetworkTags.UserDisconnect;
                    var netStream = ServerLogic.ClientStreams[idx];
                    formatter.Serialize(netStream, message);
                }
            }
            OnUserRemoval?.Invoke(disconUser);
        }
    }
}
