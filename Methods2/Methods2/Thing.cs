using System;
using System.Collections.Generic;
using System.Text;


namespace Methods2
{
    class Thing
    {
        //optional int y parameter
        public int Add(int x, int y = 0)
        {
            int result = x + y;
            return result;
        }


    }
}
