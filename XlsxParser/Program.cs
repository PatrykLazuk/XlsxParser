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
            Engine engine = new Engine();
            var lista = engine.Load_MSFT_PN_form_GPL(@"C:\tests\Global Parts List.xlsx");
            
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
