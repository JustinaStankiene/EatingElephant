using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Numbers
    {
        public void SwapNumbers(ref int num1, ref int num2)
        {
            int num3 = num1;
            num1 = num2;
            num2 = num3;
        }

    }
}
