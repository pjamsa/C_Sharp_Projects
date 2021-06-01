using System;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Paul";
            string middle = "William";
            string last = "Jamsa";

            Console.WriteLine(first + " "  + middle + " " + last);
            string up = first.ToUpper();
            Console.WriteLine(up);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("I am the most interesting man in the a romm.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
