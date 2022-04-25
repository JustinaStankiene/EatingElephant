using ClassLibrary1;
using NUnit.Framework;

namespace EatingElephant.Tests
{
    public class AddMethodShould
    {
        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(1, 1, 2)]
        [TestCase(3, 5, 8)]
        public void AddTwoNumbers(double num1, double num2, double result)
        {
            var calculator = new Calculator();
            var sum = calculator.Add(num1, num2);

            Assert.That(sum, Is.EqualTo(result));
        }
    }
}