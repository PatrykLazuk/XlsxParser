using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace XlsxParser
{
    public class MSFT_PN_Cognos
    {
        [DisplayName("PART NUMBER")]
        public string PN { get; set; }

        [DisplayName("PART DESCRIPTION")]
        public string Description { get; set; }

        [DisplayName("ROUTING CLASS")]
        public string RoutingClass { get; set; }

        [DisplayName("ROUTING SUBCLASS")]
        public string RoutingSubclass { get; set; }

        [DisplayName("WEIGHT")]
        public double Weight { get; set; }

        [DisplayName("WEIGHT UOM")]
        public string WeightUOM { get; set; }

        [DisplayName("HEIGHT")]
        public double Height { get; set; }

        [DisplayName("WIDTH")]
        public double Width { get; set; }

        [DisplayName("DEPTH")]
        public double Depth { get; set; }

        [DisplayName("DIMENSION UOM")]
        public string DimensionUOM { get; set; }

        [DisplayName("PACKING MATERIAL PART NO")]
        public string PackagingPN { get; set; }

        [DisplayName("CUSTOMER")]
        public string Customer { get; set; }

        [DisplayName("PRODUCT CLASS")]
        public string ProductClass { get; set; }

        [DisplayName("PRODUCT SUBCLASS")]
        public string ProductSubclass { get; set; }

        [DisplayName("MODEL NUMBER")]
        public string ModelNumber { get; set; }

        [DisplayName("PRODUCT PLATFORM")]
        public string ProductPlatform { get; set; }

        [DisplayName("PRODUCT LINE")]
        public string ProductLine { get; set; }

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
    }
}
