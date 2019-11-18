using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;

namespace XlsxParser
{
    public class Engine
    {
        private Config _config;
        
        public MSFT_Engine _MSFT_Engine;

        public Engine(Config config)
        {
            _config = config;
            _MSFT_Engine = new MSFT_Engine(config);
        }

        
        
    }
}
