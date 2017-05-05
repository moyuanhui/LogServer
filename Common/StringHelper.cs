using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common
{
    public class StringHelper
    {
        public static string HiddenPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length > 7)
            {
                string newphoneNumber = phoneNumber.Remove(3, 4);
                return newphoneNumber.Insert(3, "****");
            }
            else
            {
                string newphoneNumber = phoneNumber.Remove(3, phoneNumber.Length);
                return newphoneNumber.Insert(3, "****");
            }
        }
    }
}
