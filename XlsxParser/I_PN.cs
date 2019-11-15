using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxParser
{
    public interface I_PN
    {
        public string PN { get; set; }
        public string Description { get; set; }
        public string Class { get; set; }
        public string Subclass { get; set; }
        public string MPP { get; set; }
    }
}
