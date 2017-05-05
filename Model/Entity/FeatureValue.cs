using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class FeatureValue : Entity
    {
        public string FeatureValueID { get; set; }
        public string FeatureVal { get; set; }
        public string FeatureValueDescription { get; set; }
        public Nullable<int> FeatureValueSequenceNO { get; set; }
        public string CommodityFeatureID { get; set; }
        public string Remarks { get; set; }
    }
}
