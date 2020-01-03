using System.ComponentModel;

namespace XlsxParser
{
    internal class MSFT_Class_Matrix : IClassMatrix
    {
        [DisplayName("Platform/Series")]
        public string Platform { get; set; }

        [DisplayName("PRODUCT CLASS")]
        public string Class { get; set; }

        [DisplayName("PRODUCT SUBCLASS")]
        public string Subclass { get; set; }
    }
}