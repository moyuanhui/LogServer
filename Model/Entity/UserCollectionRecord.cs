using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class UserCollectionRecord : Entity
    {
        public string RecordID { get; set; }
        public string MemberPhone { get; set; }
        public string MemberID { get; set; }
        public string ObjectID { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public Nullable<System.DateTime> CollectionTime { get; set; }
        public Nullable<int> Number { get; set; }
        public string Remarks { get; set; }
    }
}
