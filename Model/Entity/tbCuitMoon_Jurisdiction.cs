using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class tbCuitMoon_Jurisdiction : Entity
    {
        public string CuitMoon_JurisdictionID { get; set; }
        public string CuitMoon_JurisdictionName { get; set; }
        public string CuitMoon_JurisdictionCode { get; set; }
        public string CuitMoon_ModuleID { get; set; }
        public string CuitMoon_JurisdictionStatus { get; set; }
        public Nullable<int> CuitMoon_JurisdictionOrderNum { get; set; }
        public string CuitMoon_JurisdictionDescription { get; set; }
        public string CuitMoon_JurisdictionRemarks { get; set; }
    }
}
