namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzersTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            var myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            var log = new LogAnalyzer(myFakeManager);

            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
        }
    }

    internal class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;
        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }
}