using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step247
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee() { firstName = "Sample", lastName = "Student" };

            employee.Quit();
            Console.ReadLine();
        }
    }
}
