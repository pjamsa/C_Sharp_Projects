using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    class Thing
    {
        public void Divide(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);
        }
        // 1st overloading of function
        public void Divide(double x)
        {
            double equation = x / 50.5;
            int result = Convert.ToInt32(equation);
            Console.WriteLine(result);
        }

        // passing in variables parameters output num1 and num2
        public static void Add(out int num3, out int num4)
        {
            num3 = 100;
            num4 = 200;
            num3 += num3;
            num4 += num4;
        }
        

    }
}
