using NUnit.Framework;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace EatingElephant.Tests
{
    class Calculatorshould
    {
        [Test]
        public void MultiplyThreeIntegers()
        {
            var calculator = new Calculator();

            var result = calculator.Multiply(1, 2, 3);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void AddTwoIntegers()
        {
            var calculator = new Calculator();

            var result = calculator.Add(6, 2);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void SubtractTwoIntegers()
        {
            var calculator = new Calculator();

            var result = calculator.SubtractTwoNumbers(6, 2);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void MultiplyTwoIntegers()
        {
            var calculator = new Calculator();

            var result = calculator.MultiplyTwoNumbers(6, 2);

            Assert.AreEqual(12, result);
        }

        [Test]
        public void DivideTwoIntegers()
        {
            var calculator = new Calculator();

            var result = calculator.DivideTwoNumbers(6, 2);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void FindReminder()
        {
            var calculator = new Calculator();

            var result = calculator.FindReminder(6, 2);

            Assert.AreEqual(0, result);
        }

        private double Square(double num)
        {
            return num * num;
        }
    }
}
