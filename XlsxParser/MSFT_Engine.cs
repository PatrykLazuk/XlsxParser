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
        private List<MSFT_PN_Cognos> LoadCognosReport()
        {
            if (!File.Exists(_msft_config.Cognos_Report_Location))
            {
                throw new DirectoryNotFoundException("Cognos report not found");
            }
            else
            {
                return _parser.LoadXlsx<MSFT_PN_Cognos>(_msft_config.Cognos_Report_Location, "page", 1);
            }
        }

        public List<MSFT_PN> New_MSFT_PNs()
        {
            var PNs_from_Cognos = LoadCognosReport();
            var PNs_from_GPL = Load_MSFT_PN_form_GPL();
            var tmp = new List<MSFT_PN>();
            foreach (var GPL_PN in PNs_from_GPL)
            {
                var result = PNs_from_Cognos.Find(i => i.PN == GPL_PN.PN);
                if (result is null) tmp.Add(GPL_PN);
            }
            return tmp;

        }




        public List<Template_Base> Create_Template(List<MSFT_PN> PNs, MSFT_Template_Type template_type)
        {
            List<Template_Base> created_template = new List<Template_Base>();
            foreach (var PN in PNs)
            {
                foreach (var setupline in template_type.SetupList)
                {
                    Template_Base template_line = new Template_Base()
                    {
                        Part_Number = PN.PN,
                        Part_Description = PN.Description,
                        Location = setupline.Location,
                        Owner = setupline.Owner,
                        Condition = setupline.Condition,
                        BCN_REQ = setupline.BCN_REQ,
                        SN_REQ =  setupline.SN_REQ
                    };
                    created_template.Add(template_line);
                }
            }
            return created_template;
        }
    }
}
