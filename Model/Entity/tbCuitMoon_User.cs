using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class tbCuitMoon_User : Entity
    {
        public string CuitMoon_UserID { get; set; }
        public string CuitMoon_UserName { get; set; }
        public string CuitMoon_UserPassWord { get; set; }
        public string CuitMoon_UserRealName { get; set; }
        public string CuitMoon_UserSex { get; set; }
        public Nullable<System.DateTime> CuitMoon_UserBirthday { get; set; }
        public string CuitMoon_UserCellphone { get; set; }
        public string CuitMoon_UserAddress { get; set; }
        public string CuitMoon_UserZipCode { get; set; }
        public string CuitMoon_UserEmail { get; set; }
        public string CuitMoon_UserQQ { get; set; }
        public string CuitMoon_UserMSN { get; set; }
        public Nullable<System.DateTime> CuitMoon_UserRegTime { get; set; }
        public Nullable<long> CuitMoon_UserLoginCount { get; set; }
        public string CuitMoon_UserStatus { get; set; }
        public string CuitMoon_AreaCode { get; set; }
        public string CuitMoon_DepartmentID { get; set; }
        public string CuitMoon_UserLoginStatus { get; set; }
        public string CuitMoon_UserWorkingStatus { get; set; }
        public string CuitMoon_UserLevel { get; set; }
        public Nullable<decimal> CuitMoon_Discount { get; set; }
        public string CuitMoon_UserRemarks { get; set; }
    }
}
