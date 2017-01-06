using System;
using System.Drawing;

namespace CommonLib
{
    [Serializable]
    public class User : CommonVars
    {
        public int Userid { get; set; }
        public string Username { get; set; }

        public User() {}

        public User(int userId)
        {
            Userid = userId;
        }

        public User(string ip, int port)
        {
            IpAddress = ip;
            Port = port;
        }

        public User(string ip, int port, string username, Color color)
        {
            IpAddress = ip;
            Port = port;
            Username = username;
            Color = color;
        }
    }
}
