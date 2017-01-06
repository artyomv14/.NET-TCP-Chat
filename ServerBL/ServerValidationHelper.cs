using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBL
{
    public static class ServerValidationHelper
    {
        public static bool IsIpValid;
        public static bool IsPortValid;
        public static bool IsServerValid
        {
            get
            {
                if (IsIpValid && IsPortValid)
                    return true;
                return false;
            }
        }

        public static bool IsPortInRange(this int num)
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
            IsIpValid = false;
            IsPortValid = false;  
        }
    }
}
