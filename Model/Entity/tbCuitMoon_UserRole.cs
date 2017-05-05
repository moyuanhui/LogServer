using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class tbCuitMoon_UserRole : Entity
    {
        public string CuitMoon_UserRoleID { get; set; }
        public string CuitMoon_UserID { get; set; }
        public string CuitMoon_RoleID { get; set; }
    }
}
