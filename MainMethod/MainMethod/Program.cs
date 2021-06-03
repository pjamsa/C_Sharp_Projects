using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object 
            Thing myObj = new Thing();

            // passing values to methods and then printing the response to the application
            Console.WriteLine(myObj.Add(6));
            Console.WriteLine(myObj.Add(3.2));
            Console.WriteLine(myObj.Add("100"));

        }
    }
}
