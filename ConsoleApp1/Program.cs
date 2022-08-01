using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task4
            Console.WriteLine("TASK 4");
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);


            //Task 6
            Console.WriteLine("TASK 6");

            var input = new Input();
            input.AskToInputThreeNumbers();

            var calculator = new Calculator();

            var result = calculator.Multiply(input.num1, input.num2, input.num3);

            Console.WriteLine("{0} * {1} * {2} = {3}", input.num1, input.num2, input.num3, result);

            //task 5
            Console.WriteLine("TASK 5");

            var input2 = new Input();
            input2.AskToInputTwoNumbers();

            var numbers = new Numbers();
            numbers.SwapNumbers(ref input2.num1, ref input2.num2);

            Console.WriteLine("After swapping: \n First number: {0} \n Second number: {1}", input2.num1, input2.num2);

            //Task7
            Console.WriteLine("TASK 7");

            var input3 = new Input();
            input3.AskToInputTwoNumbers();

            var calculator2 = new Calculator();
            var add = calculator2.Add(input3.num1, input3.num2);
            var sub = calculator2.SubtractTwoNumbers(input3.num1, input3.num2);
            var mul = calculator2.MultiplyTwoNumbers(input3.num1, input3.num2);
            var div = calculator2.DivideTwoNumbers(input3.num1, input3.num2);
            var rem = calculator2.FindReminder(input3.num1, input3.num2);

            Console.WriteLine("{0} + {1} = {2} \n{0} - {1} = {3} \n{0} * {1} = {4} \n{0} / {1} = {5} \n{0} mod {1} = {6}", input3.num1, input3.num2, add, sub, mul, div, rem);

            //Task8
            Console.WriteLine("TASK 8");

            var input4 = new Input();
            input4.AskToInputOneNumber();

            for(int i=0; i<=50; i++)
            {
                var result3 = calculator.MultiplyTwoNumbers(input4.num1, i);
                Console.WriteLine("{0} * {1} = {2} \n", input4.num1, i, result3);
            }

            //Task9
            Console.WriteLine("TASK 9");

            var input5 = new Input();
            input5.AskToInputFourNumbers();

            var calculator5 = new Calculator();

            var average = calculator5.FindAverage(input5.num1, input5.num2, input5.num3, input5.num4);

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", input5.num1, input5.num2, input5.num3, input5.num4, average);

            //Task10
            Console.WriteLine("TASK 10");

            var result1 = (input5.num1 + input5.num2) * input5.num3;
            var result2 = input5.num1 * input5.num2 + input5.num2 * input5.num3;

            Console.WriteLine("Result of specified numbers {0}, {1}, {2}, (x + y) * z is {3} and x * y + y * z is {4}", input5.num1, input5.num2, input5.num3, result1, result2);
        }
    }
}
