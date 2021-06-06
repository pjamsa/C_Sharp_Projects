using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactClass
{
    //New abstract class
    abstract class Person
    {
        //Properties Given
        public string firstName;
        public string lastName;

        //abstract Method cannot have a body
        public abstract void SayName();
        
    }
}
