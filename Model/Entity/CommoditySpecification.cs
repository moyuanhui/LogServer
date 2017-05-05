using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class CommoditySpecification : Entity
    {
        public string SpecificationID { get; set; }
        public string SpecificationName { get; set; }
        public string SpecificationCode { get; set; }
        public string SpecificationDescription { get; set; }
        public Nullable<int> SpecificationSequenceNO { get; set; }
        public string CommodityID { get; set; }
        public string CommodityTypeID { get; set; }
        public string BaseSpecificationID { get; set; }
        public string Remarks { get; set; }
    }
}
