using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step261
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please endter the current day of the week.");
            string enteredDay = Console.ReadLine();

            try
            {
                Days.DaysOfWeek day = (Days.DaysOfWeek)Enum.Parse(typeof(Days.DaysOfWeek), enteredDay);
                Console.WriteLine("You entered " + day);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                
            }

            Console.ReadLine();
                       
        }
    }
}
