using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace XlsxParser
{
    public class Template_Base
    {
        [DisplayName("ACTION CODE")]    
        public string Action_Code { get; set; }

        [DisplayName("PART NUMBER")]
        public string Part_Number { get; set; }

        [DisplayName("PART DESCRIPTION")]
        public string Part_Description { get; set; }

        [DisplayName("ROUTING CLASS")]
        public string Routing_Class { get; set; }

        [DisplayName("ROUTING SUBCLASS")]
        public string Routing_Subclass { get; set; }

        [DisplayName("UNIT OF MEASURE")]
        public string Unit_Of_Measure { get; set; }

        [DisplayName("LEAD DAYS")]
        public string Lead_Days { get; set; }

        [DisplayName("WEIGHT")]
        public double Weight { get; set; }

        [DisplayName("WEIGHT UOM")]
        public string Weight_UOM { get; set; }

        [DisplayName("HEIGHT")]
        public double Height { get; set; }

        [DisplayName("WIDTH")]
        public double Width { get; set; }

        [DisplayName("DEPTH")]
        public double Depth { get; set; }

        [DisplayName("DIMENSION UOM")]
        public string Dimension_UOM { get; set; }

        [DisplayName("PACKING MATERIAL PART NO")]
        public string Packaging_PN { get; set; }

        [DisplayName("CUSTOMER")]
        public string Customer { get; set; }

        [DisplayName("PRODUCT CLASS")]
        public string Product_Class { get; set; }

        [DisplayName("PRODUCT SUBCLASS")]
        public string Product_Subclass { get; set; }

        [DisplayName("GL CATEGORY")]
        public string GL_Category { get; set; }

        [DisplayName("MODEL NUMBER")]
        public string Model_Number { get; set; }

        [DisplayName("PRODUCT PLATFORM")]
        public string Product_Platform { get; set; }

        [DisplayName("PRODUCT LINE")]
        public string Product_Line { get; set; }

        [DisplayName("MATERIAL TYPE")]
        public string Material_Type { get; set; }

        [DisplayName("HAZARD CODE")]
        public string Hazard_Code { get; set; }

        [DisplayName("SPOHIER")]
        public string SPO_Hier { get; set; }

        [DisplayName("CONTAINER FILTER")]
        public string Container_Filter { get; set; }

        [DisplayName("SPO RELEVANT")]
        public string SPO_Relevant { get; set; }

        [DisplayName("SPM RELEVANT")]
        public string SPM_Relevant { get; set; }

        [DisplayName("SAP PART NO")]
        public string SAP_PN { get; set; }

        [DisplayName("MPN MANAGED")]
        public string MPN_Managed { get; set; }

        [DisplayName("LOCATION")]
        public string Location { get; set; }

        [DisplayName("OWNER")]
        public string Owner { get; set; }

        [DisplayName("CONDITION")]
        public string Condition { get; set; }

        [DisplayName("BCN REQ")]
        public string BCN_REQ { get; set; }

        [DisplayName("SN REQ")]
        public string SN_REQ { get; set; }

        [DisplayName("SOURCE TYPE")]
        public string Source_Type { get; set; }





    }
}
