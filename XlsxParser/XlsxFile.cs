using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace XlsxParser
{
    public class XlsxFile
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Age")]
        public int Age { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime Birthday { get; set; }

        [DisplayName("Salary")]
        public int Salary { get; set; }

        [DisplayName("Manager")]
        public bool Manager { get; set; }

    }
}
