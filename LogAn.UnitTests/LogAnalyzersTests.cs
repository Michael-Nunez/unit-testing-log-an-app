namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzersTests
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            var mockService = new FakeWebService();
            var log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            StringAssert.Contains("Filename too short: abc.ext", mockService.LastError);
        }
    }
}