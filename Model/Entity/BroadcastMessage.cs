using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{ 
    public class BroadcastMessage : Entity
    {
        public string MessageID { get; set; }
        public string MessageTitle { get; set; }
        public string MessageContent { get; set; }
        public string MessageType { get; set; }
        public string MessageObjectID { get; set; }
        public string MessageObjectType { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
    }
}