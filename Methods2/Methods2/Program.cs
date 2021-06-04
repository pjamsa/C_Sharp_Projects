using System;


namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            // new object created
            Thing myObj = new Thing();

            //Gets input from user
            Console.WriteLine("Please insert a whole number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number or not. The choice is ours.");

            int y;
            int answer;  
            
            // out keyword passes argument to method
            if(int.TryParse(Console.ReadLine(), out y))
            {
                answer = myObj.Add(x, y);
            }
            else
            {
                answer = myObj.Add(x);
            }
            Console.WriteLine(answer);
            
            
            //int y = Convert.ToInt32(Console.ReadLine());
            //int answer = myObj.Add(x, y);
            //Console.WriteLine("\n" + answer1);



        }
    }
}
