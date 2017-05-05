using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class CommodityEvaluate : Entity
    {
        public string EvaluateID { get; set; }
        public string OrderID { get; set; }
        public string CommodityID { get; set; }
        public string SkuID { get; set; }
        public string CommodityType { get; set; }
        public Nullable<int> EvaluateGrade { get; set; }
        public Nullable<int> EvaluateRating { get; set; }
        public string EvaluateTag { get; set; }
        public string EvaluateDetail { get; set; }
        public Nullable<System.DateTime> EvaluateTime { get; set; }
        public string MemberID { get; set; }
        public string Remarks { get; set; }
        public string EvaluateState { get; set; }
    }
}
