using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        int hoursWorked1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
        int annualSalary1 = ((hourlyRate1 * hoursWorked1) * 52);
        Console.WriteLine("Annual salary of Person 1: \n" + string.Format("{0:n0}", annualSalary1));
        int annualSalary2 = ((hourlyRate2 * hoursWorked2) * 52);
        Console.WriteLine("Annual salary of Person 2: \n" + string.Format("{0:n0}", annualSalary2));
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool salaryCompare = annualSalary1 > annualSalary2;
        Console.WriteLine(salaryCompare);
        Console.ReadLine();
        }
    }

