using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated class
            Class1 myObj = new Class1();
            // calling Add method and passing two numbers
            myObj.Add(5, 6);
            myObj.Add(x: 13, y: 15);
        }
    }
}
