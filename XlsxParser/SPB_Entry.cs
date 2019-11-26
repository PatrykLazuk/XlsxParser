using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace XlsxParser
{
    public class SPB_Entry
    {
        [DisplayName("Part Type")]
        public string Part_type { get; set; }

        [DisplayName("Level")]
        public double Level { get; set; }

        [DisplayName("OSSP Orderable PN Yes/No")]
        public string Orderable { get; set; }

        [DisplayName("Line Item")]
        public double Line_Item { get; set; }

        [DisplayName("Spare Kit PN")]
        public string Kit_PN { get; set; }

        [DisplayName("Rev")]
        public string Revision { get; set; }

        [DisplayName("Cross Plant Status")]
        public string Cross_Plant_Status { get; set; }

        [DisplayName("Qty")]
        public double Quantity { get; set; }

        [DisplayName("Pri Alt Gen")]
        public string Pri_Alt_Gen { get; set; }

        [DisplayName("HP 6-3 Component or SA PN")]
        public string Core_PN { get; set; }

        [DisplayName("HP Part Description")]
        public string PN_Description { get; set; }

        [DisplayName("ODM Part Number")]
        public string ODM_PN { get; set; }

        [DisplayName("ODM Part Description")]
        public string ODM_Description { get; set; }

        [DisplayName("ODM Bulk Part Number")]
        public string ODM_Bulk_PN { get; set; }

        [DisplayName("ODM Production MOQ")]
        public double ODM_Production_MOQ { get; set; }

        [DisplayName("ODM Post-Production MOQ")]
        public double ODM_Postproduction_MOQ { get; set; }

        [DisplayName("Part Supplier (ODM/OEM)")]
        public string Part_Supplier { get; set; }

        [DisplayName("Model / Mfg Pn")]
        public string MFG_PN { get; set; }

        [DisplayName("Comment")]
        public string Comment { get; set; }
    }
}
