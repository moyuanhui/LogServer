using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class UserEquipment : Entity
    {
        public string RecordID { get; set; }
        public string EquipmentType { get; set; }
        public string MemberID { get; set; }
        public string EquipmentID { get; set; }
        public string ChannelID { get; set; }
    }
}
