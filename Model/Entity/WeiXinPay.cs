using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class WeiXinPay : Entity
    {
        public string WeiXinPayID { get; set; }
        public string WX_Key { get; set; }
        public string ApplyID { get; set; }
        public string PartnerID { get; set; }
        public string PartnerName { get; set; }
        public string PartnerKey { get; set; }
        public string MCHID { get; set; }
        public string WX_AppId { get; set; }
        public string WX_AppSecret { get; set; }
        public string WX_OpenId { get; set; }
        public string apiclient_cert_p12 { get; set; }
        public string apiclient_cert_pem { get; set; }
        public string apiclient_key_pem { get; set; }
        public string rootca_pem { get; set; }
    }
}
