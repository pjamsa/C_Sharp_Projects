using System;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\paul_\Logs_c#\log2.txt", true))
            {
                file.WriteLine(userNum);
            }
            Console.WriteLine("Your information was saved in the file: log2.txt");

        }
    }
}
