using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class LotteryAward : Entity
    {
        public string AwardID { get; set; }
        public string AwardName { get; set; }
        public string AwardImgUrl { get; set; }
        public string AwardType { get; set; }
        public Nullable<int> PresentValue { get; set; }
        public Nullable<int> RemainingQuantity { get; set; }
        public Nullable<int> AwardLevel { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public string Remarks { get; set; }
    }
}
