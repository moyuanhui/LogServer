using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class ShippingAddress : Entity
    {
        public string AddressID { get; set; }
        public string MemberID { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string AddressDetails { get; set; }
        public string IDCard { get; set; }
        public string ContacterName { get; set; }
        public string Telephone { get; set; }
    }
}
