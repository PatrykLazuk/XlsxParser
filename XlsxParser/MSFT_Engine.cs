using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XlsxParser
{
    public class MSFT_Engine
    {
        private Parser _parser;
        private MSFT_Class_Logic _class_logic;
        public MSFT_Engine(string MSFT_ClassMatrix)
        {
            _parser = new Parser();
            //TODO wyciagnac lokalizację matrixa do configa
            _class_logic = new MSFT_Class_Logic(MSFT_ClassMatrix, "Sheet1");
        }
        //Wyciąganie PNow MSFT z GPL
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
                    }
                    catch (Exception e)
                    {
                        //TODO Log it!
                    }
                    finally
                    {
                        PNs.Add(pn);
                    }

                }
            }
            return PNs;
        }

        public List<MSFT_PN> New_MSFT_PNs(List<MSFT_PN> PNs_from_GPL, List<MSFT_PN_Cognos> PNs_from_Cognos)
        {
            var tmp = new List<MSFT_PN>();
            foreach (var GPL_PN in PNs_from_GPL)
            {
                var result = PNs_from_Cognos.Find(i => i.PN == GPL_PN.PN);
                if (result is null) tmp.Add(GPL_PN);
            }
            return tmp;
            
        }
    }
}
