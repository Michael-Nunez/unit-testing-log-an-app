namespace LogAn
{
    public class LogAnalyzer2
    {
        private ILogger _logger;
        private IWebService _webService;

        public LogAnalyzer2(ILogger logger, IWebService webService)
        {
            _logger = logger;
            _webService = webService;
        }

        public int MinimumNameLength { get; set; }

        public void Analyze(string fileName)
        {
            if (fileName.Length < MinimumNameLength)
            {
                try
                {
                    _logger.LogError(string.Format("Filename too short: {0}", fileName));
                }
                catch (Exception e)
                {
                    _webService.Write("Error from logger: " + e);
                }
            }
        }
    }
}