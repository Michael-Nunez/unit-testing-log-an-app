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
        [Category("Fast Tests")]
        public void IsValidFileName_ValidFile_ReturnsTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whatever.slf");
            Assert.IsTrue(result, "filename should be valid!!!");
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
            LogAnalyzer la = MakeAnalyzer();
            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
            StringAssert.Contains("filename has to be provided", ex.Message);
        }

        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }
    }
}