namespace LogAn.UnitTests
{
    [TestFixture]
    public class MemCalcullatorTests
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            var calc = MakeCalc();
            int lastSum = calc.Sum();

            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            var calc = MakeCalc();
            calc.Add(1);
            int sum = calc.Sum();

            Assert.AreEqual(1, sum);
        }

        private MemCalcullator MakeCalc()
        {
            return new MemCalcullator();
        }
    }
}