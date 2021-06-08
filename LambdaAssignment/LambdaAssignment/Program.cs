using System;
using System.Collections.Generic;

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

            List<Employee> newList2 = new List<Employee>();
            Employee emp = newList.Add(x => x.FirstName == "Joe"});       
            
            //var emp2 = employees.FindAll(x => x.FirstName == "Joe");  

            //foreach (var emp in emp2)
            //{
            //    Console.WriteLine(emp);
            //}
            
            

        }
    }

}
