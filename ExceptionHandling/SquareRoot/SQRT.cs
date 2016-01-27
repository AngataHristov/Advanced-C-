// Problem 1. Square root
// 
// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SQRT
{
    static void Main()
    {
        Console.Write("Enter integer number: ");

        try
        {
            int number = int.Parse(Console.ReadLine());
            double root = Math.Sqrt(number);
            Console.WriteLine("The square root is {0:F2}", root);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!Data entered is not a valid number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid input! End of input is wrong!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid input! Can not calculate square root of negaive number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input! The number is too big or too small!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
