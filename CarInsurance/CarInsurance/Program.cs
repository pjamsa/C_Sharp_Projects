using System;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer True or False");
            bool duiInquiry = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool isQualified = (age > 15 && duiInquiry == false && tickets < 4);
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
