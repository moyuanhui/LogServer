using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class tbCuitMoon_Log : Entity
    {
        public string CuitMoon_LogID { get; set; }
        public string CuitMoon_LogType { get; set; }
        public string CuitMoon_LogOperationUserName { get; set; }
        public string CuitMoon_LogOperationIPv4 { get; set; }
        public string CuitMoon_LogOperationIPv6 { get; set; }
        public Nullable<System.DateTime> CuitMoon_LogOperationTime { get; set; }
        public string CuitMoon_LogOperationName { get; set; }
        public string CuitMoon_LogOperationURL { get; set; }
        public string CuitMoon_LogRemarks { get; set; }
    }
}
