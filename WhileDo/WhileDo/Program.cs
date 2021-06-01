using System;

namespace WhileDo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 10)
            {
                Console.WriteLine(number);
                number++;
            }

            int num = 10;
            do
            {
                Console.WriteLine(num);
                num++;
            }
            while (num < 20);
                
        }
    }
}
