using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 
    public class Alipay : Entity
    {
        public string ShopAlipayID { get; set; }
        public string ShopID { get; set; }
        public string APPID { get; set; }
        public string SellerEmail { get; set; }
        public string PartnerID { get; set; }
        public string SellerID { get; set; }
        public string MD5KEY { get; set; }
        public string PartnerPrivKey { get; set; }
        public string PartnerPrivKey_PKCS8 { get; set; }
        public string PartnerPubKey { get; set; }
        public string AlipayPubKey { get; set; }
        public string WapKey { get; set; }
        public string WapPrivateKey { get; set; }
        public string WapPublicKey { get; set; }
        public string Remarks { get; set; }
    }
}
