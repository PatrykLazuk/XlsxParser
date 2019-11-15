using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace XlsxParser
{
    public class CSVWriter
    {
        public static void WriteCsv<T>(List<T> list, string filePath, char separator)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                PropertyInfo[] propsTable = list[0].GetType().GetProperties();
                string headerLine = "";

                for (int i = 0; i < propsTable.Length; i++)
                {
                    headerLine += propsTable[i].Name;
                    if (i < propsTable.Length - 1)
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
