using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();
            parser.LoadXlsx<XlsxFile>(@"C:\tests\TEST.xlsx", "Arkusz1");
        }
    }
}
