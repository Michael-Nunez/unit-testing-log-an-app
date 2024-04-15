namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzersTests
    {
        [Test]
        [Category("Fast Tests")]
        public void IsValidFileName_ValidFile_ReturnsTrue()
        {
            var m_analyzer = MakeAnalyzer();
            bool result = m_analyzer.IsValidLogFileName("whatever.slf");
            Assert.IsTrue(result, "filename should be valid!!!");
        }

        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
            var m_analyzer = MakeAnalyzer();
            bool result = m_analyzer.IsValidLogFileName("whatever.slf");
            Assert.IsTrue(result, "filename should be valid!!!");
        }

        [Test]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {
            var m_analyzer = MakeAnalyzer();
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

        [TestCase("badname.foo", false)]
        [TestCase("badname.slf", true)]
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string file,
            bool expected)
        {
            var la = MakeAnalyzer();
            la.IsValidLogFileName(file);
            Assert.AreEqual(expected, la.WasLastFileNameValid);
        }

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }
    }
}