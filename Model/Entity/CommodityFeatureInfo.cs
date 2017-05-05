using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class CommodityFeatureInfo : Entity
    {
        public string CommodityFeatureInfoID { get; set; }
        public string CommodityID { get; set; }
        public string FeatureValueID { get; set; }
        public string FeatureValue { get; set; }
        public string CommodityFeatureID { get; set; }
        public string CommodityFeatureName { get; set; }
    }
}
