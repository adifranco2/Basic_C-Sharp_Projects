using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step314
{
    class Age
    {
        public class valueException : Exception
        {
           public valueException()
                : base() { }
           public valueException(string message)
                :base (message) { }
        }
    }
}
