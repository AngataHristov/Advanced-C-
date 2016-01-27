// Calculate the product of n!

using System;
using System.Numerics;

class WhileFact
{
    static void Main()
    {
        Console.Write("Enter number of members: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger product = 1;
        int counter = 1;
        Console.Write("The sequence is: ");

        while (counter <= n)
        {
            Console.Write(" {0}", counter);
            product *= counter;
            counter++;
        }
        Console.WriteLine();
        Console.WriteLine("n!={0}", product);
        Console.WriteLine();

        // BigInteger product = 1;
        // while (n>0)
        // {
        //     product *= n;
        //     n--;
        // }
        // Console.WriteLine(n);
    }
}
