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

        [DisplayName("CYCLE COUNT CODE")]
        public string Cycle_Count_Code { get; set; }

        [DisplayName("BUYER ANALYZER")]
        public string Buyer_Analyzer { get; set; }

        [DisplayName("MIN STOCK QTY")]
        public int Min_Stock_Qty { get; set; }

        [DisplayName("MAX STOCK QTY")]
        public int Max_Stock_Qty { get; set; }

        [DisplayName("VALUE CLASS")]
        public string Value_Cost { get; set; }

        [DisplayName("STANDARD COST")]
        public double Standard_cost { get; set; }

        [DisplayName("UNIT COST")]
        public double Unit_Cost { get; set; }

        [DisplayName("DEFAULFT WAREHOUSE")]
        public string Default_Warehouse { get; set; }

        [DisplayName("DEFAULT STOCK LOCATION")]
        public string Default_Stock_Location { get; set; }

        [DisplayName("DEFAULT BIN")]
        public string Default_Bin { get; set; }

        [DisplayName("OBA CLASS CODE")]
        public string Oba_Class_Code { get; set; }

        [DisplayName("SAFETY STOCK QTY")]
        public int Safety_Stock_Qty { get; set; }

        [DisplayName("REORDER POINT QTY")]
        public int Reorder_Point_Qty { get; set; }

        [DisplayName("ECONOMIC ORDER QTY")]
        public int Economic_Stock_Qty { get; set; }

        [DisplayName("REORDER MAX QTY")]
        public int Reorder_Max_Qty { get; set; }

        [DisplayName("OBA LOT SIZE")]
        public int Oba_Lot_Size { get; set; }

        [DisplayName("PACK OUT TEMPLATE")]
        public string Pack_Out_Template { get; set; }

        [DisplayName("INACTIVE")]
        public string Inactive { get; set; }

        [DisplayName("CYCLE COUNT PERIOD")]
        public string Cycle_Count_Period { get; set; }

        [DisplayName("PGAFF:")]
        public List<string> PGA_FlexFields {get; set;}



    }
}
