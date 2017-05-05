using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{
    public class Ad : Entity
    {
        public string AdID { get; set; }
        public string AdTitle { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }
        public Nullable<System.DateTime> AdAddTime { get; set; }
        public Nullable<int> AdSequenceNO { get; set; }
        public string Remarks { get; set; }
    }
}
