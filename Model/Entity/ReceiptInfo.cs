using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class ReceiptInfo : Entity
    {
        public string ReceiptInfoID { get; set; }
        public string Consignee { get; set; }
        public string Area { get; set; }
        public string DeliveryAddress { get; set; }
        public string ZipCode { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public Nullable<int> FrequencyOfUse { get; set; }
        public string DefaultOrNot { get; set; }
        public string MemberID { get; set; }
        public string SpareField { get; set; }
        public string Remarks { get; set; }
    }
}
