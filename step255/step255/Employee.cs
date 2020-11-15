using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step255
{
    public class Employee<T>
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<T> Things { get; set; }
    }
}
