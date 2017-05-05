using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{
    public class tbCuitMoon_Role : Entity
    {
        public string CuitMoon_RoleID { get; set; }
        public string CuitMoon_RoleName { get; set; }
        public string CuitMoon_ParentRoleID { get; set; }
        public string CuitMoon_RoleStatus { get; set; }
        public Nullable<int> CuitMoon_RoleOrderNum { get; set; }
        public string CuitMoon_RoleDescription { get; set; }
        public Nullable<int> CuitMoon_RoleLevel { get; set; }
        public string CuitMoon_RoleRemarks { get; set; }
    }
}
