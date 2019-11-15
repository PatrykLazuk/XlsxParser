using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxParser
{
    class MSFT_Class_Matrix: IClassMatrix
    {
        public string Platform { get; set; }
        public string Class { get; set; }
        public string Subclass { get; set; }
    }
}
