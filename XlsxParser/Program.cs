using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace XlsxParser
{
    class Program
    {
        public static void CreateConfig()
        {
            string MainDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Config config = new Config();
            config.Location = "Location";
            config.MSFT_Config = new MSFT_Config();
            config.MSFT_Config.Class_Matrix_Location = "Location";
            config.MSFT_Config.GPL_File_Location = "location";
            XMLSerializer.WriteAsXml<Config>(config, Path.Combine(MainDir,"Config.xml"));
        }
        static void Main(string[] args)
        {
            Parser parser = new Parser();
            var list = parser.LoadXls<SPB_Entry>(@"C:\tests\Maldives_SPB_HP_20191124.xls", "Service Program BOM", 6);
            var parttype = list.Where(i => i.Part_type == "AC Adapter");
            foreach(var line in parttype)
            {
                if(line.Kit_PN is null)
                {
                    
                }
            }


            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
