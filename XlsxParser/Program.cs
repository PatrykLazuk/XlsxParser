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
        public static string MainDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static void CreateTemplateXML()
        {
            MSFT_Template_Type _Type = new MSFT_Template_Type();
            _Type.SetupList.Add(new Template_Setup() { Location = "Bydgoszcz", Owner = "Microsoft", Condition = "New", BCN_REQ = "Y", SN_REQ = "Y" });
            _Type.SetupList.Add(new Template_Setup() { Location = "Bydgoszcz", Owner = "Microsoft", Condition = "Workable", BCN_REQ = "N", SN_REQ = "N" });
            _Type.SetupList.Add(new Template_Setup() { Location = "Bydgoszcz", Owner = "Microsoft", Condition = "Refurbished", BCN_REQ = "Y", SN_REQ = "Y" });
            _Type.SetupList.Add(new Template_Setup() { Location = "Bydgoszcz", Owner = "Microsoft", Condition = "Salvage", BCN_REQ = "N", SN_REQ = "N" });

            if(!Directory.Exists(Path.Combine(MainDir,"Templates")))
            {
                Directory.CreateDirectory(Path.Combine(MainDir, "Templates"));
            }
            var TemplatesLocation = Path.Combine(MainDir,"Templates");
            XMLSerializer.WriteAsXml<MSFT_Template_Type>(_Type, Path.Combine(TemplatesLocation, "template.xml"));
        }

        public static Config LoadConfig()
        {
            
            return XMLSerializer.ReadXmlToObj<Config>(Path.Combine(MainDir, "Config.xml"));

        }
        static void Main(string[] args)
        {
            //CreateTemplateXML();

            MSFT_Engine engine = new MSFT_Engine(LoadConfig());
            var new_pns = engine.New_MSFT_PNs();
            var ASKU = XMLSerializer.ReadXmlToObj<MSFT_Template_Type>(Path.Combine(MainDir, "Templates", "template.xml"));
            var created = engine.Create_Template(new_pns, ASKU);
            CSVWriter.WriteCsv(created, Path.Combine(MainDir, "Test.csv"),' ');
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
