using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] stringArray = { "beef", "chicken", "pork", "fish", "tofu" };

        Console.WriteLine("Select a number 0-4 to determine the protien you'll have for dinner.");
        Console.WriteLine("You're having " + stringArray[Convert.ToInt32(Console.ReadLine())]);

        int[] intArray = { 3, 2, 4, 10, 6 };

        Console.WriteLine("Pick a number to find out how many dinner guests you should expect.");
        int guestIndex = Convert.ToInt32(Console.ReadLine());

        if (guestIndex < intArray.Length)
            Console.WriteLine(intArray[guestIndex] + " dinner guests");

        else
            Console.WriteLine("That choice doesn't exist.");
       

        List<string> stringList = new List<string>();
        stringList.Add("Brownies");
        stringList.Add("Lemon Pie");
        stringList.Add("Ice Cream Sundaes");
        stringList.Add("Angel Food Cake");
        stringList.Add("Snickerdoodles");

        Console.WriteLine("Select a number 0-4 to select your dessert for the evening.");
        Console.WriteLine("Enjoy your " + stringList[Convert.ToInt32(Console.ReadLine())]);
        Console.ReadLine();

    }
}