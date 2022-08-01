using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Input
    {
        public int num1, num2, num3, num4;

        public void AskToInputOneNumber()
        {
            Console.WriteLine("Input the number");
            string input1 = Console.ReadLine();
            num1 = Convert.ToInt32(input1);
        }
        public void AskToInputTwoNumbers()
        {
            Console.WriteLine("Input the first number");
            string input1 = Console.ReadLine();
            num1 = Convert.ToInt32(input1);

            Console.WriteLine("Input the second number");
            string input2 = Console.ReadLine();
            num2 = Convert.ToInt32(input2);
        }
        public void AskToInputThreeNumbers()
        {
            Console.WriteLine("Input the first number");
            string input1 = Console.ReadLine();
            num1 = Convert.ToInt32(input1);

            Console.WriteLine("Input the second number");
            string input2 = Console.ReadLine();
            num2 = Convert.ToInt32(input2);

            Console.WriteLine("Input the third number");
            string input3 = Console.ReadLine();
            num3 = Convert.ToInt32(input3);
        }
        public void AskToInputFourNumbers()
        {
            Console.WriteLine("Input the first number");
            string input1 = Console.ReadLine();
            num1 = Convert.ToInt32(input1);

            Console.WriteLine("Input the second number");
            string input2 = Console.ReadLine();
            num2 = Convert.ToInt32(input2);

            Console.WriteLine("Input the third number");
            string input3 = Console.ReadLine();
            num3 = Convert.ToInt32(input3);

            Console.WriteLine("Input the fourth number");
            string input4 = Console.ReadLine();
            num4 = Convert.ToInt32(input4);
        }
    }
}
