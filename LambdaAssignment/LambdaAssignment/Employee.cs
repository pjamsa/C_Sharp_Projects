using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAssignment
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " ID: " + ID;
        }
    }
}
