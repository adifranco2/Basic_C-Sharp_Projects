using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace step297
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Amy\Desktop\Basic_C#_Programs\log.txt", text);
            Console.WriteLine(File.ReadAllText(@"C:\Users\Amy\Desktop\Basic_C#_Programs\log.txt"));
            Console.ReadLine();
            
        }
    }
}
