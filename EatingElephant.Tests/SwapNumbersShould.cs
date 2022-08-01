using NUnit.Framework;
using ClassLibrary1;

namespace EatingElephant.Tests
{
    class SwapNumbersShould
    {
        [Test]
        public void SwapNumbers()
        {
            int number1 = 1;
            int number2 = 2;

            var numbers = new Numbers();

            numbers.SwapNumbers(ref number1, ref number2);

            Assert.AreEqual(2, number1);
            Assert.AreEqual(1, number2);
        }

    }
}
