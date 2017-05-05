using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class Sku : Entity
    {
        public string SkuID { get; set; }
        public string SpecificationValueIDGroup { get; set; }
        public string CommodityID { get; set; }
        public string CommodityName { get; set; }
        public string ImgUrl { get; set; }
        public Nullable<int> CommodityQuantity { get; set; }
        public Nullable<int> CommoditySalesVolume { get; set; }
        public Nullable<decimal> CommodityOriginalPrice { get; set; }
        public Nullable<decimal> CommodityPrice { get; set; }
        public Nullable<int> HighPraiseCount { get; set; }
        public Nullable<int> MediumReviewCount { get; set; }
        public string BadReviewCount { get; set; }
        public Nullable<System.DateTime> CommodityAddTime { get; set; }
        public string Remarks { get; set; }
    }
}
