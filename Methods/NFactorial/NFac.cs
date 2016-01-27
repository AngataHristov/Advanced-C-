// Problem 10. N Factorial
// 
// Write a program to calculate n! for each n in the range[1..100].

using System;
using System.Numerics;
class NFac
{
    public static void Factorial(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            BigInteger product = 1;
            for (int j = 1; j <= i; j++)
            {
                product *= j;
            }
            Console.WriteLine("{0}!={1}", i, product);
        }
    }
    public static void Main()
    {
        Console.Write("Enter the number of factorials: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            Factorial(n);
        }
        Console.WriteLine();
    }
}


