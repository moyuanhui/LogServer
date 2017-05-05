using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class OrderHandleInfo : Entity
    {
        public string OrderHandleInfoID { get; set; }
        public string OrderID { get; set; }
        public string HandleInfo { get; set; }
        public string OrderHandleStatus { get; set; }
        public string OrderHandler { get; set; }
        public Nullable<System.DateTime> OrderHandleTime { get; set; }
        public string Remarks { get; set; }
    }
}
