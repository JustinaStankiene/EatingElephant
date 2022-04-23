using ClassLibrary1;
using NUnit.Framework;

namespace EatingElephant.Tests
{
    public class AddMethodShould
    {
        [Test]
        public void AddTwoNumbers()
        {
            var calculator = new Calculator();
            var sum = calculator.Add(2, 2);

            Assert.That(sum, Is.EqualTo(4));
        }
    }
}