using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class tbCuitMoon_Module : Entity
    {
        public string CuitMoon_ModuleID { get; set; }
        public string CuitMoon_ModuleName { get; set; }
        public string CuitMoon_ModuleURL { get; set; }
        public string CuitMoon_ModuleIcon { get; set; }
        public string CuitMoon_ParentModuleID { get; set; }
        public string CuitMoon_ModuleStatus { get; set; }
        public Nullable<int> CuitMoon_ModuleOrderNum { get; set; }
        public string CuitMoon_ModuleDescription { get; set; }
        public string CuitMoon_ModuleRemarks { get; set; }
    }
}
