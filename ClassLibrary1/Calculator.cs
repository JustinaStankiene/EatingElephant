using System;

namespace ClassLibrary1
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public int SubtractTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        public double DivideTwoNumbers(int num1, int num2)
        {
            return num1 / num2;
        }

        public int FindReminder(int num1, int num2)
        {
            return num1 % num2;
        }

        public double FindAverage(double num1, double num2, double num3, double num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        }

    }
}
