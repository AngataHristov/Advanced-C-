// Enter number and check, whethet it is prime.

using System;

class Prime
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int divider = 2;
        bool IsPrime = true;

        while (divider<n)
        {
            if (n % divider==0)
            {
                Console.WriteLine("The number {0} is not prime", n);
                IsPrime = false;
                break;
            }
            else
            {
                divider++;
            }
        }
        if (IsPrime)
        {
            Console.WriteLine("The number {0} is prime", n);
        }
        Console.WriteLine();
    }
}
