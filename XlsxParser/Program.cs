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
            //CreateConfig();
            //Parser parser = new Parser();
            string MainDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Engine engine = new Engine(XMLSerializer.ReadXmlToObj<Config>(Path.Combine(MainDir,"Config.xml")));
            //var new_pns = engine._MSFT_Engine.New_MSFT_PNs(parser.LoadXlsx<MSFT_PN_Cognos>(@"C:\tests\SAP SL Part Group Attribute.xlsx", "page"));
            List<Template_Base> templates = new List<Template_Base>();
            Template_Base template = new Template_Base();
            templates.Add(template);
            Template_Base template2 = new Template_Base();
            templates.Add(template2);
            Template_Base template3 = new Template_Base();
            templates.Add(template3);
            Template_Base template4 = new Template_Base();
            templates.Add(template4);

            CSVWriter.WriteCsv(templates, Path.Combine(MainDir, "Test.csv"),' ');




            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
