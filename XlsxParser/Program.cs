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
            List<GPL_Entry> lista = parser.LoadXlsx<GPL_Entry>(@"C:\tests\Global Parts List - Post August 2018 product launches- Surface v6.xlsx", "Sheet1",2);
            foreach (var row in lista)
            {
                Console.WriteLine($"{row.CreatedDate}: {row.SKU}, {row.Description}");
            }
            Console.ReadLine();
        }
    }
}
