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
            List<XlsxFile> lista = parser.LoadXlsx<XlsxFile>(@"C:\tests\TEST.xlsx", "Arkusz1",4);
            foreach (var row in lista)
            {
                Console.WriteLine($"{row.Name}, {row.LastName}, {row.Birthday}, {row.Manager}");
            }
            Console.ReadLine();
        }
    }
}
