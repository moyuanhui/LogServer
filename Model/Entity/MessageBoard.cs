using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class MessageBoard : Entity
    {
        public string MessageBoardID { get; set; }
        public string MessageBoardTitle { get; set; }
        public string MessageBoardContent { get; set; }
        public string MemberID { get; set; }
        public string ContactMethod { get; set; }
        public string Contacts { get; set; }
        public Nullable<System.DateTime> MessageTime { get; set; }
        public string ReplyContent { get; set; }
        public Nullable<System.DateTime> ReplyTime { get; set; }
        public string Remarks { get; set; }
    }
}
