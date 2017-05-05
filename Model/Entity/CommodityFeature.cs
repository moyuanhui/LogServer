using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 
    public class CommodityFeature : Entity
    {
        public string CommodityFeatureID { get; set; }
        public string CommodityTypeID { get; set; }
        public string CommodityFeatureName { get; set; }
        public string FeatureValueDataType { get; set; }
        public string FeatureDescription { get; set; }
        public string FeatureCode { get; set; }
        public Nullable<int> FeatureSequenceNO { get; set; }
        public string Remarks { get; set; }
    }
}
