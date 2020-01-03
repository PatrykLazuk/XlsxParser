using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsftBuisnessLogicLibrary.Models
{
    public class MSFT_Class_Logic
    {
        //wyszukanie odpowiedniego wiersza w matrixie
        public string[] GetClassAndSubclass(List<MSFT_Class_Matrix> classMatrix, string SKU_Plaftorm)
        {
            string[] tmp = new string[2];
            var result = classMatrix.Find(i => i.Platform == SKU_Plaftorm);
            if (!(result == null))
            {
                tmp[0] = result.Class;
                tmp[1] = result.Subclass;
            }
            else
            {
                throw new InvalidOperationException($"Platform {SKU_Plaftorm} not found in Matrix File");
            }

            return tmp;
        }
    }
}
