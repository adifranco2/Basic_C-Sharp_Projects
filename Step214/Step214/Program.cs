using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step214
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numList = new List<int>() { 15, 27, 32, 14};

                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                
                foreach (int num in numList)
                {
                    int numberTwo = num / numberOne;
                    Console.WriteLine("The list integer divided by your number equals " + numberTwo);
                   
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
           
            finally
            {
                Console.WriteLine("You have emerged from the try/catch block.");
                Console.ReadLine();
            }
        }
    }
}
