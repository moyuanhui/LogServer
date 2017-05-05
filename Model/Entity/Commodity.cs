using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{ 


    public class Commodity : Entity
    {
        public string CommodityID { get; set; }
        public string CommodityName { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityCustomCode { get; set; }
        public string CommodityTypeID { get; set; }
        public Nullable<decimal> BasicOriginalPrice { get; set; }
        public Nullable<decimal> BasicPrice { get; set; }
        public Nullable<int> CommoditySalesVolume { get; set; }
        public string CommodityImgUrl { get; set; }
        public string HomeImgUrl { get; set; }
        public Nullable<decimal> CommodityMaxPurchase { get; set; }
        public string CommodityIntroduce { get; set; }
        public string CommoditySpecifications { get; set; }
        public string CommodityAfterService { get; set; }
        public string SkuImgSettings { get; set; }
        public string ToShelvesOrNot { get; set; }
        public string RecommendOrNot { get; set; }
        public string ShowOnHomeOrNot { get; set; }
        public Nullable<System.DateTime> CommodityAddTime { get; set; }
        public Nullable<int> CommoditySequenceNO { get; set; }
        public Nullable<int> RecommendSequenceNO { get; set; }
        public Nullable<int> HomeSequenceNO { get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        public string ImgUrl { get; set; }
        public Nullable<int> HighPraiseCount { get; set; }
        public Nullable<int> MediumReviewCount { get; set; }
        public Nullable<int> BadReviewCount { get; set; }
        public string Remarks { get; set; }
    }
}
