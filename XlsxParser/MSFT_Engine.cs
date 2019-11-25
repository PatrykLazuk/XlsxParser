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
        private MSFT_Config _msft_config;
        private MSFT_Class_Logic _class_logic;
        public MSFT_Engine(Config config)
        {
            _msft_config = config.MSFT_Config;
            _parser = new Parser();
            _class_logic = new MSFT_Class_Logic(_msft_config.Class_Matrix_Location, "Sheet1");
        }
        //Wyciąganie PNow MSFT z GPL
        private List<MSFT_PN> Load_MSFT_PN_form_GPL()
        {
            var PNs = new List<MSFT_PN>();
            if (File.Exists(_msft_config.GPL_File_Location))
            {

                var GPL_entries = _parser.LoadXlsx<GPL_Entry>(_msft_config.GPL_File_Location, "Global Parts List", 3);
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

        public List<MSFT_PN> New_MSFT_PNs(List<MSFT_PN_Cognos> PNs_from_Cognos)
        {
            var PNs_from_GPL = Load_MSFT_PN_form_GPL();
            var tmp = new List<MSFT_PN>();
            foreach (var GPL_PN in PNs_from_GPL)
            {
                var result = PNs_from_Cognos.Find(i => i.PN == GPL_PN.PN);
                if (result is null) tmp.Add(GPL_PN);
            }
            return tmp;
            
        }

        public void Create_Template(List<MSFT_PN> PNs, MSFT_Template_Type template_type)
        {
            
        }
    }
}
