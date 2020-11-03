using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step193
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "The preamble of the ";
            string two = "u.s. ";
            string three = "Constitution";

            string two2 = two.ToUpper();

            Console.WriteLine(one + two2 + three);

            StringBuilder sb = new StringBuilder("We the People of the United States, ");

            sb.Append("in Order to form a more perfect Union, \n");
            Console.WriteLine(sb);
            sb.Append("establish Justice, insure domestic Tranquility, provide for the common defense, \n");
            Console.WriteLine(sb);
            sb.Append("promote the general Welfare, and secure the Blessings of Liberty to ourselves and our Posterity, \n");
            Console.WriteLine(sb);
            sb.Append("do ordain and establish this Constitution for the United States of America."); 
            Console.WriteLine(sb);
            Console.ReadLine();





        }
    }
}
