using NUnit.Framework;

namespace CalculatorGIT.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("Mult")]
        public void TestMultiplicationTwoPositiveNumbers()
        {
            double a = 3;
            double b = 2.5;
            double result = Program.Mult(a, b);
            Assert.AreEqual(result, 7.5);
        }
        [Test]
        [Category("Mult")]
        public void TestMultiplicationTwoNegativeNumbers()
        {
            double a = -3;
            double b = -2;
            double result = Program.Mult(a, b);
            Assert.AreEqual(result, 6);
        }
        [Test]
        [Category("Mult")]
        public void TestMultiplicationTwoDifferentSignedNumbers()
        {
            double a = -3;
            double b = 2;
            double result = Program.Mult(a, b);
            Assert.AreEqual(result, -6);
        }
        [Test]
        [Category("Mult")]
        public void TestMultiplicationWithFirstNumZero()
        {
            double a = 0;
            double b = 3;
            double result = Program.Mult(a, b);
            Assert.AreEqual(result, 0);
        }
        [Test]
        [Category("Mult")]
        public void TestMultiplicationWithSecondNumZero()
        {
            double a = 3;
            double b = 0;
            double result = Program.Mult(a, b);
            Assert.AreEqual(result, 0);
        }
        [Test]
        [Category("Mult")]
        public void TestMultiplicationWithBothNumZero()
        {
            double a = 0;
            double b = 0;
            double result = Program.Mult(a, b);
            Assert.AreEqual(result, 0);
        }
    }
}