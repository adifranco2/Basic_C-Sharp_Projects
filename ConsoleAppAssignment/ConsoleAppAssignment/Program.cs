using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part one

            string[] family = { "Sam ", "Tom ", "Sue ", "Joy ", "Tim " };

            Console.WriteLine("We're creating a family. Let's give them the last name:");

            string lname = Console.ReadLine();

            for (int i = 0; i < family.Length; i++)
            {
                string member = family[i];
                family[i] = member + lname;
            }

            Console.WriteLine("The family members are:");

            foreach (string member in family)
            {
                Console.WriteLine(member);
            }

            //part two

            int count = 5;

            //while (count < 10)
            while (count <= 10)
            {
                Console.WriteLine("To infinite and beyond!");
                count++;
            }

            //part three

            int value1 = 2;
            int value2 = 4;

            while (value1 < value2)
            {
                Console.WriteLine("Four is more.");
                value1++;
            }

            while (value2 <= 6)
            {
                Console.WriteLine("This is 6 or less.");
                value2++;
            }

            //part four

            List<string> candy = new List<string>() { "Snickers", "Reeses", "Butterfinger", "Almond Joy", "Starburst" };

            Console.WriteLine("Did you favorite Halloween candy make the list? Enter it to find out.");
            string selection = Console.ReadLine();

            //Console.WriteLine("{0}", candy.FindIndex(x => x.Contains(selection)));

            for (int s = 0; s < candy.Count; s++)
            {
                if (selection == candy[s])
                {
                    Console.WriteLine(candy.IndexOf(selection));
                    break;
                }
                else if (selection != candy[s])
                {
                    Console.WriteLine("Your candy was not found.");
                    
                }
            }

            //part five

            List<string> clothes = new List<string>() { "shirt", "pants", "socks", "shirt", "underwear", "pants" };
           
            Console.WriteLine("Pick an article of clothing.");

            string item = Console.ReadLine();

            for (int k = 0; k < clothes.Count; k++)
            {
                if (clothes[k] == item)
                {
                    Console.WriteLine("Match found at index " + k);
                }
                else if (clothes[k] != item)
                {
                    Console.WriteLine("Your item was not found.");
                    
                }
            }

            //part six

            List<string> officeSupplies = new List<string>() { "pens", "paper", "printer ink", "pens", "scissors" };
            List<string> dupSupplies = new List<string>();

            foreach (string supply in officeSupplies)
            {
                if (supply != "pens")
                {
                    Console.WriteLine(supply + " - This does not appear elsewhere on the list.");
                }
                else if (supply == "pens")
                {
                    Console.WriteLine(supply + " - This appears elsewhere on the list.");
                }
            }
            Console.ReadLine();
        }
    }
}
