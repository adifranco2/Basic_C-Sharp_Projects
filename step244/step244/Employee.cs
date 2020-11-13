using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step244
{
    public class Employee : Person
    {
        public override void SayName()
        {
            base.SayName();
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
