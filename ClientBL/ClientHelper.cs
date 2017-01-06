namespace ClientBL
{
    public static class ClientHelper
    {
        public static bool IsPortValid;
        public static string ActivateUserName;
        public static bool IsPrivateMessage;
        public static bool IsSentPrivate;
        public static bool IsNickConfirm { get; set; }
        public static bool IsIpAndPortConfirm { get; set; }
        public static bool IsUserValid
        {
            get
            {
                if (IsNickConfirm  && IsIpAndPortConfirm)
                    return true;
                return false;
            }
        }

        public static bool CheckPort(this int num)
        {
            if (num >= 13000 && num <= 65535)
            {
                IsPortValid = true;
                return true;
            }
            IsPortValid = false;
            return false;
        }

        public static void ResetFlags()
        {
            IsNickConfirm = false;
            IsIpAndPortConfirm = false;
            IsPortValid = false;
        }
    }
}
