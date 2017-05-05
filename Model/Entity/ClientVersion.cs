using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 
    public class ClientVersion : Entity
    {
        public string RecordID { get; set; }
        public string ClientType { get; set; }
        public string VersionNum { get; set; }
        public string DownloadAddress { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public string ForcedToUpgrade { get; set; }
    }
}
