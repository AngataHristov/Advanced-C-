// Product of all numbers in interval [min,max].
using System;

class ProductOfAllNumbersInInt
{
    static void Main()
    {
        Console.Write("enter value for min: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("enter value for max: ");
        int max = int.Parse(Console.ReadLine());

        int product = 1;
        int number = min;

        do
        {
            product *= number;
            number++;
        } while (number <= max);
        Console.WriteLine("The product in [{0},{1}] is {2}", min, max, product);
    }
}
