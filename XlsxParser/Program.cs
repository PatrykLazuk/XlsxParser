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
            //Parser parser = new Parser();
            string MainDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Engine engine = new Engine(XMLSerializer.ReadXmlToObj<Config>(Path.Combine(MainDir,"Config.xml")));
            //var new_pns = engine._MSFT_Engine.New_MSFT_PNs(parser.LoadXlsx<MSFT_PN_Cognos>(@"C:\Users\patry\Desktop\test\SAP SL Part Group Attribute.xlsx","page"));
            //foreach (var item in new_pns)
            // {
            //        Console.WriteLine($"{item.PN} = {item.Description}");
            // }

            var template = XMLSerializer.ReadXmlToObj<MSFT_Template_Type>(Path.Combine(MainDir, "TemplateConfig.xml"));
            

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
