using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateCreatorLibrary
{
    public interface IPartNumber
    {
        string PN { get; set; }
        string Description { get; set; }
        string Class { get; set; }
        string Subclass { get; set; }
    }
}
