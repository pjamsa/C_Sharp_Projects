using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactClass
{
    // employee inherits from the person class
    class Employee : Person
    { 
        //override allows using functions from another class in this class 
        public override void SayName()
        {
            Console.WriteLine("Name: [" + firstName + " " + lastName + "]");
        }
    }
}
