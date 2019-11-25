using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.ComponentModel;
using System.Reflection;
using OfficeOpenXml;

namespace ExcelParser
{
    public class Parser
    {
        private Dictionary<string, string> GetDisplayAttributeNames<T>()
        {
            var dispNames = new Dictionary<string, string>();
            var obj = (T)Activator.CreateInstance(typeof(T));
            foreach (PropertyInfo prop in obj.GetType().GetProperties().ToList<PropertyInfo>())
            {
                string propName = prop.Name;
                dispNames[prop.GetCustomAttribute<DisplayNameAttribute>().DisplayName] = prop.Name;
            }
            return dispNames;
        }
        public List<T> LoadXlsx<T>(string path, string sheetName, int headerRowNumber = 1)
        {
            var tmp = new List<T>();
            var indexDic = new Dictionary<int, string>();
            var attNames = GetDisplayAttributeNames<T>();

            using (var workbook = new ExcelPackage(new FileInfo(path)))
            {
                //stworzenie zmiennej worksheetu
                var worksheet = workbook.Workbook.Worksheets[sheetName];
                //stworzenie slownika (Header,Index)
                for (int c = worksheet.Dimension.Start.Column; c <= worksheet.Dimension.End.Column; c++)
                {
                    var value = worksheet.Cells[headerRowNumber, c].Value;
                    if (value is null) continue;
                    if (attNames.Keys.Contains(value.ToString()))
                    {
                        indexDic[c] = worksheet.Cells[headerRowNumber, c].Value.ToString();
                    }
                }
                //stworzenie listy obiektów z kazdego row
                for (int r = headerRowNumber + 1; r <= worksheet.Dimension.End.Row; r++)
                {
                    var row = (T)Activator.CreateInstance(typeof(T));
                    for (int c = worksheet.Dimension.Start.Column; c <= worksheet.Dimension.End.Column; c++)
                    {
                        if (indexDic.Keys.Contains(c))
                        {
                            var value = worksheet.Cells[r, c].Value;

                            if (value is null) continue;
                            if (row.GetType().GetProperty(attNames[indexDic[c]]).PropertyType != value.GetType()) continue;

                            if (row.GetType().GetProperty(attNames[indexDic[c]]).PropertyType.Name.Equals("DateTime"))
                                value = DateTime.FromOADate((double)value);
                            row.GetType().GetProperty(attNames[indexDic[c]]).SetValue(row, value);
                        }
                    }
                    tmp.Add(row);
                }
            }
            return tmp;
        }
    }
}
