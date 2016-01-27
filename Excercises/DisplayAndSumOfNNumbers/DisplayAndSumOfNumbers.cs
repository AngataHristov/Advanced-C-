// Display and calculate the sum of n numbers.

using System;

class DisplayAndSumOfNumbers
{
    static void Main()
    {
        //Console.Write("Enter number of numbers: ");
        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //Console.Write("The sequence is: ");
        //for (int i = 1; i <= n; i++)
        //{
        //    Console.Write("{0} ", i);
        //    sum += i;
        //}
        //Console.WriteLine();
        //Console.WriteLine("Sum= " + sum);
        //Console.WriteLine();

        Console.Write("Enter number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int counter = 1;
        Console.Write("The sequence is: ");

        while (counter <= n)
        {
            Console.Write("{0} ", counter);
            sum += counter;
            counter++;
        }
        Console.WriteLine();
        Console.WriteLine("Sum= " + sum);
        Console.WriteLine();
    }
}
