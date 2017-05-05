using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class Storage : Entity
    {
        public string StorageID { get; set; }
        public string CommodityID { get; set; }
        public string ConsumerID { get; set; }
        public string SkuID { get; set; }
        public string CommodityType { get; set; }
        public Nullable<int> StorageQuantity { get; set; }
        public Nullable<System.DateTime> StorageTime { get; set; }
        public string StorageDescription { get; set; }
        public string Remarks { get; set; }
    }
}
