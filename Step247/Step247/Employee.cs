using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step247
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
                Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " quit thier job last week.");
        }
    }
}
