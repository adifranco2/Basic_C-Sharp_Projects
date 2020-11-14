using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step252
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { Id = 1, firstName = "Steve" };
            Employee employee1 = new Employee() { Id = 2, firstName = "Jane"};

            ReferenceEquals(employee.Id, employee1.Id);
            Console.WriteLine();

            
            
            Console.ReadLine();


        }
    }
}
