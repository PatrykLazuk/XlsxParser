using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxParser
{
    public class MSFT_Template_Type : ITemplate_Type
    {
        public List<string> Location { get; set; }
        public List<string> Owner { get; set; }
        public List<string> Condition { get; set; }

        public MSFT_Template_Type(string TemplatePath)
        {
            var template = XMLSerializer.ReadXmlToObj<MSFT_Template_Type>(TemplatePath);
            Location = template.Location;
            Owner = template.Owner;
            Condition = template.Condition;
        }
    }
}
