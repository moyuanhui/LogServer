using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class ShareRecord : Entity
    {
        public string RecordID { get; set; }
        public string Phone { get; set; }
        public string MemberID { get; set; }
        public string ObjectID { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public Nullable<int> ShareCount { get; set; }
        public string ShareType { get; set; }
        public Nullable<System.DateTime> LastShareTime { get; set; }
        public string Remarks { get; set; }
    }
}
