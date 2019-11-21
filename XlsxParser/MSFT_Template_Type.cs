using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxParser
{
    public class MSFT_Template_Type : ITemplate_Type
    {
        public List<Template_Setup> SetupList { get; set; }

        public MSFT_Template_Type()
        {
            SetupList = new List<Template_Setup>();
        }
    }
}
