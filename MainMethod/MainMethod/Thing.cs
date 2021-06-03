using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    class Thing
    {
        //C# takes passed parameters and runs them through
        //equation and returns the result
        public int Add(int x)
        {
            int result = x + 1000;
            return result;
        }
        //converts decimal to integer 
        public int Add(decimal x)
        {
            decimal equation = x + 300;
            int result = Convert.ToInt32(equation);
            return result;
        }
        //converts string to integer
        public int Add(string x)
        {
            int change = Convert.ToInt32(x);
            int result = change + 100;
            return result;
        }

    }
}
