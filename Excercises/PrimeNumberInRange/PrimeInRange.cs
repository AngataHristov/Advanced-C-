// Enter range and check, which are the prime numbers in it.

using System;

class PrimeInRange
{
    static void Main()
    {
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        for (int i = min; i <= max; i++)
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
                Console.WriteLine("The prime numbers from min to max are:{0} ", i);
            }
        }

        Console.WriteLine();

    }
}
