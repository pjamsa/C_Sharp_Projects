using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverload
{
    class Employee
    {
        public int ID;


        public static bool operator ==(Employee x, Employee y)
        {
            if (x.ID == y.ID)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee x, Employee y)
        {
            if (x.ID != y.ID)
                return true;
            else
                return false;
        }
    }
}
