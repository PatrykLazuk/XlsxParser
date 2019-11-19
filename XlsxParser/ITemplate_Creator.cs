using System.Collections.Generic;

namespace XlsxParser
{
    interface ITemplate_Type
    {
        List<string> Condition { get; set; }
        List<string> Location { get; set; }
        List<string> Owner { get; set; }
    }
}