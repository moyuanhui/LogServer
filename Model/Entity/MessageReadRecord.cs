using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class MessageReadRecord : Entity
    {
        public string RecordID { get; set; }
        public string MessageType { get; set; }
        public string MessageID { get; set; }
        public string MemberID { get; set; }
    }
}
