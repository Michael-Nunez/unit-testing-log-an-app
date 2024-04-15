namespace LogAn.UnitTests
{
    [TestFixture]
    public class MemCalcullatorTests
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            var calc = new MemCalcullator();
            int lastSum = calc.Sum();
            Assert.AreEqual(0, lastSum);
        }
    }
}