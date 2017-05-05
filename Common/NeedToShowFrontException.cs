using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common
{
    public class NeedToShowFrontException: Exception
    {
        public NeedToShowFrontException(string message) :
            base(message)
        {

        }
    }
}
