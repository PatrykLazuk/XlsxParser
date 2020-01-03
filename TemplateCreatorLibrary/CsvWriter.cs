using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TemplateCreatorLibrary
{
    public class CSVWriter
    {
        public static void WriteCsv<T>(List<T> list, string filePath, char separator = ',')
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                var propsList = list[0].GetType().GetProperties().ToList<PropertyInfo>();
                var dispAttNames = new List<string>();
                foreach (PropertyInfo prop in propsList)
                {
                    dispAttNames.Add(prop.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
                }
                string headerLine = "";

                for (int i = 0; i < dispAttNames.Count; i++)
                {
                    headerLine += dispAttNames[i];
                    if (i < dispAttNames.Count - 1)
                        headerLine += separator;
                }

                writer.WriteLine(headerLine);

                foreach (T line in list)
                {
                    PropertyInfo[] valueTable = line.GetType().GetProperties();
                    string strLine = "";
                    for (int i = 0; i < valueTable.Length; i++)
                    {
                        strLine += valueTable[i].GetValue(line);
                        if (i < valueTable.Length - 1)
                            strLine += separator;
                    }
                    writer.WriteLine(strLine);
                }
            }
        }
    }
}
