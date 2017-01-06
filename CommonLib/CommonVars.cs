using System;
using System.Drawing;

namespace CommonLib
{
    [Serializable]
    public abstract class CommonVars
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public Color Color { get; set; }
        public DateTime Time { get; set; }
    }
}
