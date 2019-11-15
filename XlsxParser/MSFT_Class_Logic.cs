using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxParser
{
    public class MSFT_Class_Logic
    {
        private readonly List<MSFT_Class_Matrix> _matrix;

        //w konstruktorze sciezka do pliku excel z matrixem platforma - class & subclass
        public MSFT_Class_Logic(string path, string arrName)
        {
            _matrix = LoadMatrix(path, arrName);
        }
        //wczytanie matrixa
        private List<MSFT_Class_Matrix> LoadMatrix(string path, string arrName)
        {
            Parser parser = new Parser();
            return parser.LoadXlsx<MSFT_Class_Matrix>(path, arrName);
        }
        //wyszukanie odpowiedniego wiersza w matrixie
        public string[] GetClassAndSubclass(string SKU_Plaftorm)
        {
            string[] tmp = new string[2];
            var result = _matrix.Find(i => i.Platform == SKU_Plaftorm);
            tmp[0] = result.Class;
            tmp[1] = result.Subclass;
            return tmp;
        }
    }
}
