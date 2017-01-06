using System;
using System.Collections.Generic;

namespace CommonLib
{
    [Serializable]
    public class Message : CommonVars
    {
        public NetworkTags Tags;
        public string MessageText { get; set; }
        public User User { get; set; }
        public List<User> ListOfUsers { get; set; }
        public List<string> PrivMessageUsernames { get; set; }
        public Message() { }

        public Message(User user)
        {
            User = user;
        }

        public Message(User user, NetworkTags tags)
        {
            User = user;
            Tags = tags;
        }
    }
}
