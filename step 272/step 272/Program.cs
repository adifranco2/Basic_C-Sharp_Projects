using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_272
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() {FirstName = "Joe", LastName = "Smith", Id = 1 });
            employees.Add(new Employee() {FirstName = "Joe", LastName = "Jones", Id = 2 });
            employees.Add(new Employee() { FirstName = "Jane", LastName = "Williams", Id = 3 });
            employees.Add(new Employee() { FirstName = "Sue", LastName = "Cooper", Id = 4 });
            employees.Add(new Employee() { FirstName = "Joy", LastName = "Thomas", Id = 5 });
            employees.Add(new Employee() { FirstName = "Tom", LastName = "Bradley", Id = 6 });
            employees.Add(new Employee() { FirstName = "Charlie", LastName = "Smith", Id = 7 });
            employees.Add(new Employee() { FirstName = "Mary", LastName = "Brown", Id = 8 });
            employees.Add(new Employee() { FirstName = "Bo", LastName = "Green", Id = 9 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Brady", Id = 10 });

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }
            
            Console.WriteLine();

            var Joes = employees.Where(x => x.FirstName == "Joe");
            foreach (var value in Joes)
            {
                Console.WriteLine(value.FirstName + " " + value.LastName);
            }
            
            Console.WriteLine();

            List<Employee> IdList = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee employee2 in IdList)
            {
                Console.WriteLine(employee2.Id + " " + employee2.LastName);
            }

            Console.ReadLine();

        }
    }
}
