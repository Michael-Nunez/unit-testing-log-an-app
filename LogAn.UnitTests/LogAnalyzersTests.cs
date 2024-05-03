using NSubstitute;
using NUnit.Framework.Internal;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzersTests
    {
        [Test]
        public void IsValid_LengthBiggerThan8_IsFalse()
        {
            var logan = GetNewAnalyzer();
            bool valid = logan.IsValid("123456789");
            Assert.IsFalse(valid);
        }

        [Test]
        public void IsValid_LengthSmallerThan8_IsTrue()
        {
            var logan = GetNewAnalyzer();
            bool valid = logan.IsValid("1234567");
            Assert.IsTrue(valid);
        }

        private LogAnalyzer GetNewAnalyzer()
        {
            var analyzer = new LogAnalyzer();
            analyzer.Initialize();
            return analyzer;
        }
    }
}