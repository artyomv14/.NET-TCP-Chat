using System;

namespace CommonLib
{
    [Serializable]
    public enum NetworkTags
    {
        Validate = 1,
        Connect = 2,
        Send = 3,
        SendPrivate = 4,
        Receive = 5,
        UserList = 6,
        TcpResponse = 7,
        UserDisconnect = 8,
        SeverDisconnect = 9,
        NoTag  = 0
    }
}
