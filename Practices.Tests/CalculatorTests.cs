using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        public void AdditionalMustCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Additional(50, 60) == 110);
        }

        [Test]
        public void SubstractionMustCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Subtraction(50, 60) == -10);
        }

        [Test]
        public void MultiplicationalMustCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Miltiplication(50, 60) == 3000);
        }

        [Test]
        public void DivisionMustCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Division(50, 5) == 10);
        }
    }
}