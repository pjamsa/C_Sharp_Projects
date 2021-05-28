using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Your package is too heavy to be shipped by package express.  Have a good day.");
                Environment.Exit(0);
            }
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package length.");
            double length = Convert.ToDouble(Console.ReadLine());
            double dimension = width + height + length;
            if (dimension > 50)
            {
                Console.WriteLine("Your package is too big to be shipped by package express.  Have a great day!");
                Environment.Exit(0);
            }
            double product = width * height * length;
            double multiply = product * weight;
            double outcome = multiply / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + outcome);
            Console.WriteLine("Thank You!");
            Console.ReadLine();
        }
    }
}
