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

        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }

        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidLogFileName_VariousExtensions_ReturnsTrue(string file, bool expected)
        {
            var analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(file);
            Assert.AreEqual(result, expected);
        }
    }
}