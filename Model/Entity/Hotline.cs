using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class Hotline : Entity
    {
        public string HotlineID { get; set; }
        public string HotlineName { get; set; }
        public string HotlinePhone { get; set; }
        public string HotlineIcon { get; set; }
        public Nullable<int> HotlineSequenceNO { get; set; }
        public string Remarks { get; set; }
    }
}
