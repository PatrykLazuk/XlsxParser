using MsftBuisnessLogicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsftBuisnessLogicLibrary
{
    public class Engine
    {
        public List<GPL_Entry> FindNewPNs(List<GPL_Entry> allGplPns, List<MSFT_PN_Cognos> allPnsFromSl)
        {
            List<GPL_Entry> tmp = new List<GPL_Entry>();
            foreach (var GPL_PN in allGplPns)
            {
                var result = allPnsFromSl.Find(i => i.PN == GPL_PN.SKU);
                if (result is null) tmp.Add(GPL_PN);
            }
            return tmp;

        }

        public List<MSFT_PN> ConvertGplToMsftPn(List<GPL_Entry> GplPnsToConvert)
        {
            var tmp = new List<MSFT_PN>();
            foreach (var gplPn in GplPnsToConvert)
            {
                var msftPn = new MSFT_PN(gplPn);
                msftPn.SetPropertiesFromGPL();
                tmp.Add(msftPn);
            }
            return tmp;
        }
    }
}
