using MsftBuisnessLogicLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XlsxParserLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Parser parser = new Parser();
            Console.WriteLine("Beginning process");

            Console.WriteLine("Parsing xlsx files...");

            timer.Start();
            string reportPath = @"C:\Users\lazukp\Desktop\Testy\SL_REPORT_MSFT.xlsx";
            var reportPNs = parser.LoadXlsx<MSFT_PN_Cognos>(reportPath, "page",1);

            Console.WriteLine($"SL_REPORT_MSFT. Time: {timer.Elapsed.TotalSeconds}");
            timer.Restart();

            string gplPath = @"C:\Users\lazukp\Desktop\Testy\Global Parts List 2020-02-03.xlsx";
            var gplPNs = parser.LoadXlsx<GPL_Entry>(gplPath, "Global Parts List", 3);

            Console.WriteLine($"Global Parts. Time: {timer.Elapsed.TotalSeconds}");
            timer.Restart();

            Engine engine = new Engine();
            Console.WriteLine("Searching for new PNs...");
            engine.FindNewPNs(gplPNs, reportPNs);

            Console.WriteLine($"New PNs found. Time: {timer.Elapsed.TotalSeconds}");
            timer.Stop();
            Console.WriteLine("Process complete");
            Console.ReadLine();
        }
    }
}
