﻿using System;

namespace AbstactClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //calling abstract method
            employee.SayName();

            employee.Quit();
        }
    }
}
