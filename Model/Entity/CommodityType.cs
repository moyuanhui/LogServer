using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class CommodityType : Entity
    {
        public string CommodityTypeID { get; set; }
        public string CommodityTypeName { get; set; }
        public string ParentCommodityTypeID { get; set; }
        public string CommodityTypeIcon { get; set; }
        public string CommodityTypeSubstitutionIcon { get; set; }
        public string CommodityTypeDescription { get; set; }
        public Nullable<int> CommodityTypeSequenceNO { get; set; }
        public Nullable<System.DateTime> TypeAddTime { get; set; }
        public string Remarks { get; set; }
    }
}
