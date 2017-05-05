using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class PushMessage : Entity
    {
        public string MessageID { get; set; }
        public string PushType { get; set; }
        public string PushObjectID { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public string custom_content { get; set; }
        public Nullable<System.DateTime> PushTime { get; set; }
    }
}
