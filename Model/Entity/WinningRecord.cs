using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class WinningRecord : Entity
    {
        public string RecordID { get; set; }
        public string AwardID { get; set; }
        public string MemberID { get; set; }
        public Nullable<System.DateTime> WinningTime { get; set; }
        public string Remarks { get; set; }
    }
}
