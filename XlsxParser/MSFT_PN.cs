using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxParser
{
    public class MSFT_PN : I_PN
    {
        private MSFT_Class_Logic _logic;
        public MSFT_PN()
        {
            //to trzeba wyciagnac do klasy nadrzednej, zeby matrix nie byl wczytywany za kazdym razem kiedy tworzony jest PN
            _logic = new MSFT_Class_Logic("", "");
        }
        public string PN { get; set; }
        public string Description { get; set; }
        public string Class { get; set; }
        public string Subclass { get; set; }
        public string MPP { get; set; }
        public char Serialized_Item { get; set; }
        public string PartType { get; set; }
        public string Platform { get; set; }


        public void SetPropertiesFromGPL(GPL_Entry gPL_Entry)
        {
            this.PN = gPL_Entry.SKU;
            this.Description = gPL_Entry.Description;
            this.Platform = gPL_Entry.Platform;
            this.Class = _logic.GetClassAndSubclass(gPL_Entry.Platform)[0];
            this.Subclass = _logic.GetClassAndSubclass(gPL_Entry.Platform)[1];

        }
    }
}
