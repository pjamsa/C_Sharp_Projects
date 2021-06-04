using System;

namespace ClassAssignment
{
    //changed to static Class
    static class Program
    {
        static void Main(string[] args)
        {
            Thing myObj = new Thing();
            Console.WriteLine("Please enter a whole number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            myObj.Divide(userNum);

            // declared variables but no attached values
            int num1, num2;
            
            //passing multiple variables to method
            Thing.Add(out num1, out num2);

            Console.WriteLine("If you add this number by itself it is: {0}", num1);
            Console.WriteLine("If you add this number by itself it is: {0}", num2);

            // calling function and passing double parameter
            myObj.Divide(100.5);
            
        }
    }
}
