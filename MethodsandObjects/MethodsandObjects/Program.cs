using System;

namespace MethodsandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiated object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();

        }
    }
}
