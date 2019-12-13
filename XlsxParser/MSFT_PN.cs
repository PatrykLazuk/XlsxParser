namespace XlsxParser
{
    public class MSFT_PN : I_PN
    {
        private MSFT_Class_Logic _logic;
        private GPL_Entry _GPL_PN;

        public MSFT_PN(GPL_Entry GPL_PN, MSFT_Class_Logic classLogic)
        {
            _GPL_PN = GPL_PN;
            _logic = classLogic;
        }

        public string PN { get; set; }
        public string Description { get; set; }
        public string Class { get; set; }
        public string Subclass { get; set; }
        public string ModelNumber { get; set; }
        public string ProductPlatform { get; set; }
        public string ProductLine { get; set; }
        public string MPP { get; set; }
        public char Serialized_Item { get; set; }
        public string PartType { get; set; }
        public string Platform { get; set; }

        public void SetPropertiesFromGPL()
        {
            this.PN = _GPL_PN.SKU;
            this.Description = _GPL_PN.Description;
            this.Platform = _GPL_PN.Platform;
            switch (_GPL_PN.SKUType)
            {
                case "A":
                case "B":
                case "C":
                case "D":
                case "A/TAA":
                case "Demo":
                case "TAA/A":
                    this.ModelNumber = _GPL_PN.E_SKU_1;
                    this.ProductPlatform = _GPL_PN.NF_SKU_1;
                    this.PartType = "A-SKU";
                    //TODO dodac logike do przydzielania product line
                    break;

                case "EXC":
                case "EXC/TAA":
                case "FRU":
                case "TAA/EXC":
                    this.ModelNumber = _GPL_PN.SKU;
                    this.ProductPlatform = _GPL_PN.G_SKU;
                    this.PartType = "E-SKU";
                    //TODO dodac logike do przydzielania product line
                    break;

                case "G":
                case "NF":
                    this.ProductPlatform = _GPL_PN.SKU;
                    this.PartType = "G-SKU";
                    break;

                case "ORT":
                    this.ProductPlatform = _GPL_PN.SKU;
                    this.PartType = "R-SKU";
                    break;

                default:
                    break;
            }
            this.Class = _logic.GetClassAndSubclass(_GPL_PN.Platform)[0];
            this.Subclass = _logic.GetClassAndSubclass(_GPL_PN.Platform)[1];
        }
    }
}