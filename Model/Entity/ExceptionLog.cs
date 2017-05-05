using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class ExceptionLog : Entity
    {
        public string ExceptionLogID { get; set; }
        public string ExceptionInfo { get; set; }
        public string ScreenCaptureImg { get; set; }
        public Nullable<System.DateTime> HappenedTime { get; set; }
        public string SystemName { get; set; }
        public string PageUrl { get; set; }
        public string ExceptionType { get; set; }
        public string FunctionName { get; set; }
        public string ImportantParam { get; set; }
        public string CauseAnalysis { get; set; }
        public string HandlingInfo { get; set; }
        public Nullable<System.DateTime> HandlingTime { get; set; }
        public string UserName { get; set; }
        public string Remarks { get; set; }
    }
}
