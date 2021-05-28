using System;

namespace UserEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please Enter Your Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName);
            Console.WriteLine("It's time to do some math.");
            Console.WriteLine("Please enter a whole number:");
            int multiplyNumber = Convert.ToInt32(Console.ReadLine());
            int multiplySolved = multiplyNumber * 50;
            Console.WriteLine("Your number multiplied by 50 is " + multiplySolved);
            Console.WriteLine("Please enter another number: ");
            int addNumber = Convert.ToInt32(Console.ReadLine());
            int addSolved = addNumber + 25;
            Console.WriteLine("Your number + 25 is " + addSolved);
            Console.WriteLine("Please enter another number:");
            int divideNumber = Convert.ToInt32(Console.ReadLine());
            double divideSolved = divideNumber / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + divideSolved);
            Console.WriteLine("Please enter another number:");
            int checkNum = Convert.ToInt32(Console.ReadLine());
            bool checkSolved = checkNum > 50;
            Console.WriteLine("Is your number greater than 50? The answer is: " + checkSolved);
            Console.WriteLine("Please  enter another number: ");
            int modulusFinder = Convert.ToInt32(Console.ReadLine());
            int remainder = modulusFinder % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder);
            Console.ReadLine();
        }
    }
}
