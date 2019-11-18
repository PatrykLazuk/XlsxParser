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
            MSFT_Engine engine = new MSFT_Engine(@"C:\tests\MSFT Class Matrix.xlsx");
            List<MSFT_PN> GPL = engine.Load_MSFT_PN_form_GPL(@"C:\tests\Global Parts List.xlsx");
            List<MSFT_PN_Cognos> Cognos = parser.LoadXlsx<MSFT_PN_Cognos>(@"C:\tests\SAP SL Part Group Attribute.xlsx", "page");
            var lista = engine.New_MSFT_PNs(GPL, Cognos);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
