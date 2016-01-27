// Problem 1. Leap year
// 
// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

class LeapYear
{ 
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
        Console.WriteLine();
    }
}
