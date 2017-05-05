using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class DeliveryMethod : Entity
    {
        public string DeliveryMethodID { get; set; }
        public string DeliveryMethodName { get; set; }
        public string DeliveryMethodCode { get; set; }
        public Nullable<decimal> DefaultFreight { get; set; }
        public string Remarks { get; set; }
    }
}
