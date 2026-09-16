

using Lommeregner;

namespace LommeregnerTest
{
    [TestClass]
    public sealed class UnitTest1
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(10, calc.Sum(4, 6));
        }


        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(2, calc.Subtract(6, 4));
        }

        [TestMethod]
        public void TestDicide1()
        {
            Assert.AreEqual(4, calc.Divide(8, 2));
        }

        [TestMethod]
        public void TestDicide2()
        {
            Assert.AreEqual(2.67, Math.Round(calc.Divide(8, 3)),2);
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(8, calc.Multiply(4, 2));
        }

    }
}
