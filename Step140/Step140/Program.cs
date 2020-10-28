using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step140
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool assistance = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
