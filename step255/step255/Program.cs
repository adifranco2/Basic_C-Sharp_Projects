using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step255
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "purple", "clover", "salami" };

            Console.WriteLine("string list:");
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 2, 5, 13 };

            Console.WriteLine("int list:");
            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
