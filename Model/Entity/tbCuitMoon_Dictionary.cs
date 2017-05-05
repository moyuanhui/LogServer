using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{

    public class tbCuitMoon_Dictionary : Entity
    {
        public string CuitMoon_DictionaryID { get; set; }
        public string CuitMoon_DictionaryName { get; set; }
        public string CuitMoon_DictionaryCode { get; set; }
        public string CuitMoon_ParentDictionaryCode { get; set; }
        public Nullable<int> CuitMoon_DictionaryOrderNum { get; set; }
        public string CuitMoon_DictionaryRemarks { get; set; }
    }
}
