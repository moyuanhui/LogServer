using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class SpecificationValue : Entity
    {
        public string SpecificationValueID { get; set; }
        public string SpecificationID { get; set; }
        public string BaseSpecificationValueID { get; set; }
        public string CommodityID { get; set; }
        public string SpecificationVal { get; set; }
        public string SpecificationValueDescription { get; set; }
        public string ImgUrl { get; set; }
        public Nullable<int> SpecificationValueSequenceNO { get; set; }
        public string Reamrks { get; set; }
    }
}
