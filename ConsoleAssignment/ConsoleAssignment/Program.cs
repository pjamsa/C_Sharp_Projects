using System;
using System.Collections.Generic;

namespace ConsoleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new array 
            string[] sharks = new string[] { "Bull", "Great White", "Tiger", "Hammerhead" };

            // gathering user input
            Console.WriteLine("What animal was famous in the Movie, Jaws?");
            string userAnswer = Console.ReadLine();

            // iterating through list of sharks and adding the useranswer after each array item
            foreach (string shark in sharks)
            {
                string additionShark = shark + " " + userAnswer;
            }

            //iterating through and displaying each name of shark in the outpu
            foreach (string shark in sharks)
            {
                Console.WriteLine(shark);
            }

            // integer array
            int[] nums = { 0, 4, 33, 490, 39, 4 };

            // without i++ this loop will be infinite
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 50)
                {
                    Console.WriteLine(nums[i]);
                }
            }

            // starts at age 40 and iterates until Entry AARP age
            for (int age = 40; age < 100; age++)
            {
                if (age < 50)
                {
                    Console.WriteLine("You are too young to sign up for AARP at age: " + age);
                }
            }

            // iterates until 21 
            for (int age1 = 15; age1 < 100; age1++)
            {
                if (age1 <= 20)
                {
                    Console.WriteLine("You are too young to buy beer at age: " + age1);
                }

            }

            // creates list of bikes.  
            List<string> bikes = new List<string>() { "Surly", "Santa Cruz", "Specialized", "All-City", "Trek", "Giant" };

            //asks user input to search for certain bike brand
            Console.WriteLine("Search our catalog to see if we have the brand of bike you're looking for.\n");
            string userBike = Console.ReadLine();

            // if user request is contained in the list of bikes process moves forward, gives index number of that bike
            if (bikes.Contains(userBike))
            {
                foreach (string bike in bikes)
                {
                    if (bike == userBike)
                    {
                        Console.WriteLine("\n" + bike + "'s index number is: {0}.", bikes.IndexOf(userBike));
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("Your search did not yield any results.");
            }


            //sets up list and asks for user input. gives index number of animal if search results match.
            List<string> housePets = new List<string>() { "cat", "dog", "cat", "gerbil", "dog", "dog", "snake", "goose" };
            Console.WriteLine("\nSearch a common type of house pet.");
            string userPet = Console.ReadLine();

            if (housePets.Contains(userPet))
            {
                for (int index = 0; index < housePets.Count; index++)
                    if (housePets[index] == userPet)
                        Console.WriteLine("\nThe index number of " + userPet + " is: {0}.\n\n", index);
            }
            else
            {
                Console.WriteLine("\nYour search didn't yield any results\n\n");
            }


            //created blank dictionary to store values to determine duplicates in the list
            List<string> cars = new List<string>() { "dodge", "ford", "mazda", "ford", "BMW", "toyoya" };
            List<string> cars2 = new List<string>();

            
            
            foreach (string car in cars)
            {
                if (!cars2.Contains(car))
                {
                    cars2.Add(car);
                    Console.WriteLine(car + " is a new addition to the list.");
                }
                else
                {
                    Console.WriteLine(car + " was already added to the list.");
                }
            }

            













        }
    }
}
