using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class Text : Entity
    {
        public string TextID { get; set; }
        public string TextTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Abstract { get; set; }
        public string TextSource { get; set; }
        public string Author { get; set; }
        public string TextContent { get; set; }
        public Nullable<int> TextSequenceNO { get; set; }
        public Nullable<System.DateTime> TextAddTime { get; set; }
        public string Remarks { get; set; }
    }
}
