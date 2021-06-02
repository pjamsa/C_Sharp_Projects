using System;
using System.Collections.Generic;


namespace IntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //try block handles errors 
            try
            {
                // creates list and asks for user input 
                List<int> ages = new List<int> { 25, 24, 23, 22, 40, 55, 20, 49, 19, 21 };
                Console.WriteLine("Please choose a number.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int age in ages)
                {
                    Console.WriteLine(age / userNum);
                }
            }
            // these catch blocks handle any erors the user might encounter from user error
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            // this block let's users know that they have left the try/catch block
            finally
            {
                Console.WriteLine("Program has left the try/catch block and continued with program execution");
            }
        }
    }
}
