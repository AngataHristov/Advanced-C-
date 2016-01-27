// Enter range (0 to N) and check, which are the prime numbers in it.

using System;

class PrimeInRange
{
    static void Main()
    {
        Console.Write("Enter number of the numbers: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The prime numbers are: \n1 \n2");

        for (int i = 3; i < n; i++)
        {
            int divider = 2;
            bool IsPrime = true;

            while (divider < i)
            {
                if (i % divider == 0)
                {
                    IsPrime = false;
                    break;
                }
                divider++;
            }
            if (IsPrime)
            {
                Console.WriteLine("{0}", i);
            }
        }
        Console.WriteLine();
    }
}
