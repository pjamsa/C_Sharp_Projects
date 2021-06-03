using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    class Thing
    {
        //Method Overloading Class Methods
        public int Add(int x)
        {
            int result = x + 1000;
            return result;
        }
        
        public double Add(double x)
        {
            double result = x + 300;
            return result;
        }
        
        public string Add(string x)
        {
            //have to change string value to an integer
            int change = Convert.ToInt32(x);
            int result = change + 100;
            // compiler cannot implicitly change int to string
            //that's why i had to add .ToString(); 
            return result.ToString();
        }

    }
}
