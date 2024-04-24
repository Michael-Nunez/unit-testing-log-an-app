namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzersTests
    {
        [Test]
        public void Analyze_WebService_Throws_SendEmail()
        {
            var stubService = new FakeWebService();
            stubService.ToThrow = new Exception("fake exception");

            var mockEmail = new FakeEmailService();

            var log = new LogAnalyzer(stubService, mockEmail);

            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            StringAssert.Contains("someone@somewhere.com", mockEmail.To);
            StringAssert.Contains("can't log", mockEmail.Subject);
            StringAssert.Contains("fake exception", mockEmail.Body);
        }
    }
}