using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("How old are you?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge > 0)
                {
                    Console.WriteLine("You are {0} years old. Congrats on making it this far.", userAge);
                }
                else
                {
                    Console.WriteLine("What are you playing at?  Goodbye!");
                }
                
            }
             
            catch (Exception)
            {
                Console.WriteLine("Please enter your age in digits.");
            }

            


        }
    }
}
