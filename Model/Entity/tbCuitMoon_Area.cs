using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class tbCuitMoon_Area : Entity
    {
        public string CuitMoon_AreaID { get; set; }
        public string CuitMoon_AreaName { get; set; }
        public string CuitMoon_AreaCode { get; set; }
        public string CuitMoon_ParentAreaCode { get; set; }
        public Nullable<int> CuitMoon_AreaOrderNum { get; set; }
        public string CuitMoon_AreaRemarks { get; set; }
    }
}
