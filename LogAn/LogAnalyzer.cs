namespace LogAn
{
    public class LogAnalyzer
    {
        private IWebService _service;

        public LogAnalyzer(IWebService service)
        {
            _service = service;
        }

        public void Analyze(string fileName)
        {
            const int minimunCharactersLengthExpected = 8;

            if (fileName.Length < minimunCharactersLengthExpected)
            {
                _service.LogError($"Filename too short: {fileName}");
            }
        }
    }
}