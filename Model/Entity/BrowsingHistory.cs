using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{
    public class BrowsingHistory : Entity
    {
        public string BrowsingHistoryID { get; set; }
        public Nullable<System.DateTime> BrowseTime { get; set; }
        public string CommodityID { get; set; }
        public string Remarks { get; set; }
    }
}
