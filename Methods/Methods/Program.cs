using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates object from created NewClass
            NewClass myObj = new NewClass();
            
            //Gathers 
            Console.WriteLine("Please enter a whole number");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Calls passes paramater to NewClass methods and then calls method
            int answer1 = myObj.Add(userNum);
            Console.WriteLine(answer1);

            int answer2 = myObj.Subtract(userNum);
            Console.WriteLine(answer2);

            int answer3 = myObj.Multiply(userNum);
            Console.WriteLine(answer3);
        }
    }
}
