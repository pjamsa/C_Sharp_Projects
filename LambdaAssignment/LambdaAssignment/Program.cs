using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", ID = 1000 });
            employees.Add(new Employee() { FirstName = "Larry", LastName = "Cable", ID = 1001 });
            employees.Add(new Employee() { FirstName = "Kurt", LastName = "Kobain", ID = 1002 });
            employees.Add(new Employee() { FirstName = "Lisa", LastName = "Presley", ID = 1003 });
            employees.Add(new Employee() { FirstName = "Jimmy", LastName = "Buffet", ID = 1004 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Dirt", ID = 1005 });
            employees.Add(new Employee() { FirstName = "Tina", LastName = "Turner", ID = 1006 });
            employees.Add(new Employee() { FirstName = "Al", LastName = "Sharpton", ID = 1007 });
            employees.Add(new Employee() { FirstName = "Pam", LastName = "Anderson", ID = 1008 });
            employees.Add(new Employee() { FirstName = "Igor", LastName = "Stravinsky", ID = 1009 });

            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                    Console.WriteLine(employee);
                }
            }

            // new list using lambda to find all employees named Joe
            List<Employee> newList2 = employees.Where(x => x.FirstName == "Joe").ToList();
            
            //new list using lambda to find all employees with an ID greater than 5.
            List<Employee> newList3 = employees.Where(x => x.ID > 5).ToList();

            
            
         
            
            

        }
    }

}
