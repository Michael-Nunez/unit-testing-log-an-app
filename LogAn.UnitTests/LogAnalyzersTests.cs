using NSubstitute;
using NUnit.Framework.Internal;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzersTests
    {
        [SetUp]
        public void SetUp()
        {
            logan = new LogAnalyzer();
            logan.Initialize();
        }

        private LogAnalyzer logan = null;

        [Test]
        public void IsValid_LengthBiggerThan8_IsFalse()
        {
            bool valid = logan.IsValid("123456789");
            Assert.IsFalse(valid);
        }

        [Test]
        public void IsValid_LengthSmallerThan8_IsTrue()
        {
            bool valid = logan.IsValid("1234567");
            Assert.IsTrue(valid);
        }
    }
}