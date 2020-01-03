using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsftBuisnessLogicLibrary.Models
{
    public class MSFT_Class_Matrix
    {
        [DisplayName("Platform/Series")]
        public string Platform { get; set; }

        [DisplayName("PRODUCT CLASS")]
        public string Class { get; set; }

        [DisplayName("PRODUCT SUBCLASS")]
        public string Subclass { get; set; }
    }
}
