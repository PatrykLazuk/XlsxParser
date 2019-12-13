using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace XlsxParser
{
    internal class Program
    {
        public static void CreateConfig()
        {
            string MainDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Config config = new Config();
            config.Location = "Location";
            config.MSFT_Config = new MSFT_Config();
            config.MSFT_Config.Class_Matrix_Location = "Location";
            config.MSFT_Config.GPL_File_Location = "location";
            XMLSerializer.WriteAsXml<Config>(config, Path.Combine(MainDir, "Config.xml"));
        }

        private static void Main(string[] args)
        {
            
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}