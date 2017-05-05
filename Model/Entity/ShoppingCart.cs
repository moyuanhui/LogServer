using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class ShoppingCart : Entity
    {
        public string ShoppingCartID { get; set; }
        public string DataID { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public string MemberID { get; set; }
        public string Remarks { get; set; }
    }
}
