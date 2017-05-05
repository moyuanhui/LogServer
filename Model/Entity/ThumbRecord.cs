using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class ThumbRecord : Entity
    {
        public string ThumbID { get; set; }
        public string MemberID { get; set; }
        public string EvaluateID { get; set; }
    }
}
