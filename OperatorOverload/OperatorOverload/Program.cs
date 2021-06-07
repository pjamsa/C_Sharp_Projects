using System;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.ID1 = 3015;
            employee.ID2 = 3016;

            if (employee.ID1 == employee.ID2)
                Console.WriteLine("ID1 and ID2 are equal");
            else
                Console.WriteLine("ID1 and ID2 are not equal");

            
       
        

           
        }
    }
}
