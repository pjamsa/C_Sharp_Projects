using System;

namespace WhileDo
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop 
            int number = 0;
            while (number < 10)
            {
                Console.WriteLine(number);
                number++;
            }

            //do while loop
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
