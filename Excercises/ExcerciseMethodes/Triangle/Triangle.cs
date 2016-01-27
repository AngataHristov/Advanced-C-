using System;

class Triangle
{
    public static void Print(int max)
    {
        for (int col = 1; col <= max; col++)
        {
            Console.Write("{0} ", col);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            Print(row);
        }
        for (int row = 1; row < n; row++)
        {
            Print(n - row);
        }
    }
}


