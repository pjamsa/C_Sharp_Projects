using System;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.ID = 3015;
            emp2.ID = 3016;


            Console.WriteLine(emp1 == emp2);
            
            
            //if (emp1 == emp2)
            //    Console.WriteLine("ID1 and ID2 are equal");
            //else
            //    Console.WriteLine("ID1 and ID2 are not equal");

            
       
        

           
        }
    }
}
