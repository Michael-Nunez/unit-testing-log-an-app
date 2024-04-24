namespace LogAn
{
    public class LogAnalyzer
    {
        private IWebService _webService {  get; set; }
        private IEmailService _emailService { get; set; }

        public LogAnalyzer(IWebService service, IEmailService emailService)
        {
            _webService = service;
            _emailService = emailService;
        }

        public void Analyze(string fileName)
        {
            const int minimunCharactersLengthExpected = 8;

            if (fileName.Length < minimunCharactersLengthExpected)
            {
                try
                {
                    _webService.LogError($"Filename too short: {fileName}");
                }
                catch (Exception e)
                {
                    _emailService.SendEmail("someone@somewhere.com", "can't log", e.Message);
                }
            }
        }
    }
}