using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace step190
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a color.");
            string color = Console.ReadLine();
            bool isPicked = color == "red";

            while (!isPicked)
            {
                switch(color)
                {
                    case "red":
                        Console.WriteLine("You picked red.  You are correct!");
                        isPicked = true;
                        break;
                    default:
                        Console.WriteLine("You picked wrong. The answer's red.");
                        Console.WriteLine("Pick a color.");
                        color = Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("What's your favorite day of the week?");
            string day = Console.ReadLine();
            bool favDay = day == "sunday";

            do
            {
                switch(day)
                {
                    case "monday":
                        Console.WriteLine("Monday's not a very good day.");
                        Console.WriteLine("Pick another day.");
                        day = Console.ReadLine();
                        break;
                    case "saturday":
                        Console.WriteLine("Saturday is a better day but not the best day.");
                        Console.WriteLine("Pick another day.");
                        day = Console.ReadLine();
                        break;
                    case "sunday":
                        Console.WriteLine("That's the best day!");
                        favDay = true;
                        break;
                    default:
                        Console.WriteLine("That day's okay but there's a better one.");
                        Console.WriteLine("Pick another day.");
                        day = Console.ReadLine();
                        break;
                }

            }

            while (!favDay);

            Console.Read();

        }
    }
}
