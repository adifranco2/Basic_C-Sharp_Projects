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
            if (ReferenceEquals(employee.Id, employee1.Id))
            {
                return true;
            }
            if (ReferenceEquals(employee.Id, null))
            {
                return false;
            }
            if (ReferenceEquals(employee1.Id, null))
            {
                return false;
            }
            return employee.Id.Equals(employee1.Id);
        }
        public static bool operator!= (Employee employee, Employee employee1)
        {
            return !(employee.Id == employee1.Id);
        }

    }
}
