using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial text
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            // Reads the input from user
            string userName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            // C# Casting Now program can use INT without errors
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            //Boolean variable conversion
            bool helpNeeded = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there anyu positive experiences you'd like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            //end of program
        }
    }
}
