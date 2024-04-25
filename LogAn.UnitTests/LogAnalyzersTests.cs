using NSubstitute;
using NUnit.Framework.Internal;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzersTests
    {
        [Test]
        public void Analyze_LoggerThrows_CallsWebService()
        {
            var mockWebService = Substitute.For<FakeWebService>();

            var stubLogger = Substitute.For<FakeLogger2>();
            stubLogger
                .When(logger => logger.LogError(Arg.Any<string>()))
                .Do(info => { throw new Exception("fake exception"); });

            var analyzer2 = new LogAnalyzer2(stubLogger, mockWebService);
            analyzer2.MinimumNameLength = 8;

            string tooShortFileName = "abc.ext";
            analyzer2.Analyze(tooShortFileName);

            mockWebService.Received().Write(Arg.Is<string>(s => s.Contains("fake exception")));
        }
    }

    public class FakeWebService : IWebService
    {
        public string MessageToWebService;

        public void Write(string message)
        {
            MessageToWebService = message;
        }
    }

    public class FakeLogger2 : ILogger
    {
        public Exception WillThrow = null;
        public string LoggerGotMessage = null;

        public void LogError(string message)
        {
            LoggerGotMessage = message;

            if (WillThrow != null)
            {
                throw WillThrow;
            }
        }
    }
}