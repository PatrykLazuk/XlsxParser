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