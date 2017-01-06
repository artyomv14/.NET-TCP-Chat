using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using CommonLib;

namespace ServerBL
{
    public class Server
    {
        public bool IsConnected;
        public Socket Socket;
        private Thread ClientThread;
        private TcpListener Listener;
        public List<CommTemplate> AllClients;
        public IPAddress Address;
        public int Port;



        public Server()
        {
            Socket.
            IsConnected = false;
            var commData = new CommTemplate(Socket)
            {
                Nstream = new NetworkStream(Socket),
                Binfmt = new BinaryFormatter(),
                Thread = new Thread(Boot) {IsBackground = true}   
            };
            
        }






    }
}
