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

        [DisplayName("Description")]
        public string Description { get; set; }

        //[DisplayName("UPC")]
        //public double UPC { get; set; }

        [DisplayName("SKU Type")]
        public string SKUType { get; set; }

        [DisplayName("Platform/Series")]
        public string Platform { get; set; }
    }
}
