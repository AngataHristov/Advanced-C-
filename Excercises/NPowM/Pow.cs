// N^m

using System;

class Pow
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter grade: ");
        int power = int.Parse(Console.ReadLine());
        int result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        Console.WriteLine(result);
        Console.WriteLine();
    }
}
