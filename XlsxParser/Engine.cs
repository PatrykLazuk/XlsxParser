using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace XlsxParser
{
    public class Engine
    {
        private Parser _parser;
        private MSFT_Class_Logic _class_logic;

        public Engine()
        {
            _parser = new Parser();
            _class_logic = new MSFT_Class_Logic(@"C:\tests\MSFT Class Matrix.xlsx", "Sheet1");
        }

        public List<MSFT_PN> Load_MSFT_PN_form_GPL(string gpl_file_path)
        {
            var PNs = new List<MSFT_PN>();
            if (File.Exists(gpl_file_path))
            {

                var GPL_entries = _parser.LoadXlsx<GPL_Entry>(gpl_file_path, "Global Parts List", 3);
                foreach (var row in GPL_entries)
                {
                    MSFT_PN pn = new MSFT_PN(row, _class_logic);
                    try
                    {
                        pn.SetPropertiesFromGPL();
                        PNs.Add(pn);
                        Console.WriteLine($"{pn.PN} added to list");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine($"{pn.PN} not added to list");
                    }

                }
            }
            return PNs;
        }
    }
}
