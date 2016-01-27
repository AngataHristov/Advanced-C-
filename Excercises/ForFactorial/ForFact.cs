// Calculate the product of n!

using System;
using System.Numerics;
class ForFact
{
    static void Main()
    {
        Console.Write("Enter number of members: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger product = 1;

        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }
        Console.WriteLine("{0}!={1}",n, product);
        Console.WriteLine();
    }
}
