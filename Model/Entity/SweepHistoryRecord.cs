using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class SweepHistoryRecord : Entity
    {
        public string SweepID { get; set; }
        public string CommodityID { get; set; }
        public Nullable<System.DateTime> SweepTime { get; set; }
        public string BarCode { get; set; }
    }
}
