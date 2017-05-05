using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class OrderDetail : Entity
    {
        public string OrderDetailID { get; set; }
        public string OrderID { get; set; }
        public string CommodityID { get; set; }
        public string SkuID { get; set; }
        public string CommodityName { get; set; }
        public string CommodityImgUrl { get; set; }
        public string CommodityType { get; set; }
        public Nullable<decimal> CommodityPrice { get; set; }
        public string SpecificationsDescribe { get; set; }
        public Nullable<int> CommodityQuantity { get; set; }
        public Nullable<decimal> CommodityAmount { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public string Remarks { get; set; }
    }
}
