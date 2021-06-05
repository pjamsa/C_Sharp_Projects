using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsandObjects
{
    class Person
    {
        //Given properties 
        public string FirstName;
        public string LastName;

        public void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }


    }
}
