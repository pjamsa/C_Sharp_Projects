using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates object 
            Thing myObj = new Thing();

            //Passes parameter to method and then displays the return result
            Console.WriteLine(myObj.Add(6));
            Console.WriteLine(myObj.Add(300.5m));
            Console.WriteLine(myObj.Add("100"));



        }
    }
}
