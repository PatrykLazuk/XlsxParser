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
        static void Main(string[] args)
        {
            string MainDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Engine engine = new Engine(XMLSerializer.ReadXmlToObj<Config>(Path.Combine(MainDir,"Config.xml")));

            //Config config = new Config();
            //config.Location = "Location";
            //config.MSFT_Config = new MSFT_Config();
            //config.MSFT_Config.Class_Matrix_Location = "Location";
            //config.MSFT_Config.GPL_File_Location = "location";
            //XMLSerializer.WriteAsXml<Config>(config, Path.Combine(MainDir,"Config.xml"));

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
