using Calculator;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Calculate c1 = new Calculate();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}