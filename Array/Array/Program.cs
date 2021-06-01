using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates new array of strings
            string[] array1 = new string[] { "dog", "cat", "whale", "dolphin" };
            // allows user to choose a number and then converts the number into a number in the index
            Console.WriteLine("Please choose a number between 0 and 3 to see the name of a random animal...");
            int animal = Convert.ToInt32(Console.ReadLine());
            
            //if user selects a number greater than 3 they will get this message
            // and application will close
            if (animal > 3)
            {
                Console.WriteLine("You did not choose a valid number. Goodbye.");
                Environment.Exit(0);
            }
            Console.WriteLine(array1[animal]);

            // Creates new array of integers
            int[] array2 = new int[] { 2, 50, 33, 8000, 204 };
            
            Console.WriteLine("\nPlease choose a number between 0 and 4 to see a random number...");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //if user selects a number greater than 4 they will get this message
            // and application will close

            if (userNum > 4)
            {
                Console.WriteLine("You did not choose a valid number.  Goodbye");
                Environment.Exit(0);

            }
            Console.WriteLine(array2[userNum]);

            // Creates a list of Saws 
            List<string> intList = new List<string>();
            intList.Add("Chainsaw");
            intList.Add("Miter Saw");
            intList.Add("Table Saw");
            intList.Add("Jig Saw");
            intList.Add("Circular Saw");

            //Allows user to select a number and converts the number into an index number in the list
            Console.WriteLine("\nPlease choose a number between 0 and 4 to see a type of saw...");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[userNumber]);
            Console.ReadLine();

            





            






            
        }
    }
}
