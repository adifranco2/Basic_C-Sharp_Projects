using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step310
{
    class Employee
    {
        public Employee(int Id) : this("", "", Id)
        {
        }
        public Employee(string fName, string lName, int Id)
        {
            FirstName = fName;
            LastName = lName;
            EmployeeId = Id;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }
    }
}
