using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace XlsxParser
{
    public class GPL_Entry
    {
        [DisplayName("Change Type")]
        public string ChangeType { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Change Date")]
        public DateTime ChangeDate { get; set; }

        [DisplayName("SKU")]
        public string SKU { get; set; }

        [DisplayName("LOB")]
        public string LOB { get; set; }

        [DisplayName("SKU Description")]
        public string Description { get; set; }

        [DisplayName("UPC")]
        public double UPC { get; set; }

        [DisplayName("Commodity Type")]
        public string CommodityType { get; set; }

        [DisplayName("1PP/3PP")]
        public string PP_Type { get; set; }

        [DisplayName("SKU Type")]
        public string SKUType { get; set; }

        [DisplayName("Platform/Series")]
        public string Platform { get; set; }

        [DisplayName("Weight")]
        public double Weight { get; set; }

        [DisplayName("Length")]
        public double Length { get; set; }

        [DisplayName("Width")]
        public double Width { get; set; }

        [DisplayName("Depth")]
        public double Depth { get; set; }

        [DisplayName("Non-Functional SKU")]
        public string G_SKU { get; set; }

        [DisplayName("# of Controllers")]
        public double Controllers { get; set; }

        [DisplayName("E-SKU #1")]
        public string E_SKU_1 { get; set; }

        [DisplayName("NF SKU #1")]
        public string NF_SKU_1 { get; set; }

        [DisplayName("ADJ CODE #1")]
        public string ADJ_1 { get; set; }

        [DisplayName("E-SKU #2")]
        public string E_SKU_2 { get; set; }

        [DisplayName("NF SKU #2")]
        public string NF_SKU_2 { get; set; }

        [DisplayName("ADJ CODE #2")]
        public string ADJ_2 { get; set; }

        [DisplayName("E-SKU #3")]
        public string E_SKU_3 { get; set; }

        [DisplayName("NF SKU #3")]
        public string NF_SKU_3 { get; set; }

        [DisplayName("ADJ CODE #3")]
        public string ADJ_3 { get; set; }

        [DisplayName("E-SKU #4")]
        public string E_SKU_4 { get; set; }

        [DisplayName("NF SKU #4")]
        public string NF_SKU_4 { get; set; }

        [DisplayName("ADJ CODE #4")]
        public string ADJ_4 { get; set; }

        [DisplayName("E-SKU #5")]
        public string E_SKU_5 { get; set; }

        [DisplayName("NF SKU #5")]
        public string NF_SKU_5 { get; set; }

        [DisplayName("ADJ CODE #5")]
        public string ADJ_5 { get; set; }

        [DisplayName("E-SKU #6")]
        public string E_SKU_6 { get; set; }

        [DisplayName("NF SKU #6")]
        public string NF_SKU_6 { get; set; }

        [DisplayName("ADJ CODE #6")]
        public string ADJ_6 { get; set; }

        [DisplayName("E-SKU #7")]
        public string E_SKU_7 { get; set; }

        [DisplayName("NF SKU #7")]
        public string NF_SKU_7 { get; set; }

        [DisplayName("ADJ CODE #7")]
        public string ADJ_7 { get; set; }
    }
}
