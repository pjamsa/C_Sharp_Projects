using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Number number = new Number();
            number.Amount = 300.5m;

            Console.WriteLine(number.Amount);
        }
    }
}
