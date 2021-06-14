using System;
using System.Collections.Generic;
using System.Text;

namespace ChainConstructor
{
    // Chaining constructors fist constructors give a value to the first int ID;
    public class Employee
    {
        public Employee() : this(9001)
        {

        }

        public Employee(int ID)
        {

        }
    }
}
