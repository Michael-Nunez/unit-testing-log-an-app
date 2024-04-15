namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzersTests
    {
        private LogAnalyzer m_analyzer = null;
        
        [SetUp]
        public void SetUp()
        {
            m_analyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whatever.slf");
            Assert.IsTrue(result, "filename should be valid!!!");
        }

        [Test]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whatever.SLF");
            Assert.IsTrue(result, "filename should be valid!!!");
        }

        [Test]
        public void IsValidFileName_EmptyFileName_ThrowsException()
        {
            Assert.That(() => m_analyzer.IsValidLogFileName(string.Empty),
                        Throws.ArgumentNullException);
        }

        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }
    }
}