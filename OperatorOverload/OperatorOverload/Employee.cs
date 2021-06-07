using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverload
{
    class Employee
    {
        public int ID1;
        public int ID2;

        public static bool operator ==(ID1, ID2)
        {
            return true;
        }
    }
}
