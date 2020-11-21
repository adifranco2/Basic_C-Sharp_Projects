using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step314
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bool validAge = false;
                //int age = 0;
                //while (!validAge)
                //{
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                DateTime today = DateTime.Now;
                DateTime birthYear = today.AddYears(-age);
                //validAge = int.TryParse(Console.ReadLine(), out age);
                //}
                //if (!validAge)
                //{
                //    throw new Exception();
                //    //Console.WriteLine("Please enter digits only.")
                //}
                if (age <= 0)
                {
                    throw new Age.valueException();
                }
                else
                {
                    Console.WriteLine("Your birth year is " + birthYear.Year);
                    Console.ReadLine();
                }
            }
            catch (Age.valueException)
            {
                Console.WriteLine("Your age cannot be less than 1.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred.");
                Console.ReadLine();
                
            }

        }
    }
}
