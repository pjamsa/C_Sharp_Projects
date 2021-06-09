using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //displays current time
            Console.WriteLine(DateTime.Now);
            //get user input
            Console.WriteLine("Please enter a number:");
            // convert user input to an integer
            int userNum = Convert.ToInt32(Console.ReadLine());
            //add user input to current time
            DateTime Later = DateTime.Now.AddHours(userNum);
            Console.WriteLine("In {0} hours the time will be: " + Later, userNum);
            
            
      
        }
    }
}
