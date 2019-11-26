using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxParser
{
    public class HP_Engine
    {
        public static List<string[]> CreateSPBpartmaster(List<SPB_Entry> SPB_Contents)
        {
            var tmp = new List<string[]>();
            foreach(var row in SPB_Contents)
            {
                var stringRow = new string[3];
                if (row.Core_PN is null)
                    stringRow[0] = row.Kit_PN;
                else
                    stringRow[0] = row.Core_PN;
                stringRow[1] = row.Part_type;
                stringRow[2] = row.PN_Description;
                tmp.Add(stringRow);
            }
            return tmp;
        }
    }
}
