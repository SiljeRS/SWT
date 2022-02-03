using NUnit.Framework;
using SimpleCalculator;

namespace CalculatorTestUnit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(2.5, 3.5, 6)]
        [TestCase(-1.5, 1.5, 0)]
        [TestCase(-1, -1, -2)]
        public void TestAdd(double a, double b, double result)
        {
            // Arrange

            // Act

            // Assert

            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(2.5, 3.5, -1)]
        [TestCase(-1.5, 1.5, -3)]
        [TestCase(-1, -1, 0)]
        public void TestSubtract(double a, double b, double result)
        {
            // Arrange

            // Act

            // Assert

            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 5, 10)]
        [TestCase(-1, 5, -5)]
        [TestCase(-1, -1, 1)]
        public void TestMultiply(double a, double b, double result)
        {
            // Arrange

            // Act

            // Assert

            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 5, 32)]
        [TestCase(7, 4, 2401)]
        [TestCase(3, 3, 27)]
        public void TestPower(double x, double exp, double result)
        {
            // Arrange

            // Act
           
            // Assert

            Assert.That(uut.Power(x, exp), Is.EqualTo(result));
        }

       
        public void TestAccumulate()
        {
            // Arrange

            // Act
            uut.Power(2, 5);

            // Assert

            Assert.That(uut.Accumulator, Is.EqualTo(32));
        }

    }
}