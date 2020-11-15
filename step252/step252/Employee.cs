using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step252
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }



        public static bool operator== (Employee employee, Employee employee1)
        {
            bool result = false;

            if (employee.Id == employee1.Id)
            {
                result = true;
            }

            return result;
        }

        public static bool operator!= (Employee employee, Employee employee1)
        {
            bool result = false;

            if (employee.Id != employee1.Id)
            {
                result = true;
            }

            return result;
        }
    }
}
