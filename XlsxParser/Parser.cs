using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Reflection;
using OfficeOpenXml;

namespace XlsxParser
{
    public class Parser
    {
        public List<string> GetDisplayAttributeNames<T>()
        {
            var dispNames = new List<string>();
            var obj = (T)Activator.CreateInstance(typeof(T));
            foreach (PropertyInfo prop in obj.GetType().GetProperties().ToList<PropertyInfo>())
            {
                dispNames.Add(prop.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
            }
            return dispNames;
        }
        public List<T> LoadXlsx<T>(string path, string sheetName)
        {
            var obj = (T)Activator.CreateInstance(typeof(T));
            var tmp = new List<T>();
            var indexList = new List<int>();

            using (var workbook = new ExcelPackage(new FileInfo(path)))
            {
                var worksheet = workbook.Workbook.Worksheets[sheetName];
                for(int c = worksheet.Dimension.Start.Column;c<=worksheet.Dimension.End.Column;c++)
                {
                    if(GetDisplayAttributeNames<T>().Contains(worksheet.Cells[1,c].Value.ToString()))
                    {
                        indexList.Add(c);
                    }
                }

            }
                
        }
    }
}
