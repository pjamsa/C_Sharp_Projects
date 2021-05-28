using System;

namespace IncomeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opening text Gathers input about person 1
            Console.WriteLine("Anonymous Income Comparison Program!");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours a week do you work?");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours a week do you work?");
            double hoursworked2 = Convert.ToDouble(Console.ReadLine());
            
            // Equations to evaluate salaries of Person 1 and 2
            Console.WriteLine("Annual salary of Person 1:");
            double salary1 = hourlyRate * hoursWorked * 52;
            Console.WriteLine(salary1);

            Console.WriteLine("Annual salary of Person 2:");
            double salary2 = hourlyRate2 * hoursworked2 * 52;
            Console.WriteLine(salary2);
            
            //Boolean Logic to Display who makes more money
            Console.WriteLine("Does Person 1 make more than Person 2");
            bool higherEarner = salary1 > salary2;
            Console.WriteLine(higherEarner);
            Console.ReadLine();

        }
    }
}
