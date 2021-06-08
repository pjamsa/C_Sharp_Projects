using System;

namespace EnumParse
{
    class Program
    {
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            //asks user for input
            Console.WriteLine("Please enter the current day of the week:");
            string userDay = Console.ReadLine();
            string value = userDay;
            DayOfWeek day;
            try
            {
                // if possible converts user input to enum 
               day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), value);
                Console.WriteLine(userDay + " was recorded.  Thank you for your input.");
            }
            //gives user an error message if their input doesn't match
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);             
            }
            
            
            
        }
    }
}
