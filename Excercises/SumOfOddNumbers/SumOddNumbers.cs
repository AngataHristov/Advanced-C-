// Sum and product of all odd numbers ,without 7 and 9 in interval ot p to n.

using System;

class SumOddNumbers
{
    static void Main()
    {
        Console.Write("Enter value for p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int product = 1;

        for (int i = p; i <= n; i++)
        {
            if (i % 2 == 0 || i == 7 || i == 9)
            {
                continue;
            }
            sum += i;
            product *= i;
        }
        Console.WriteLine("sum={0} , prosuct={1}", sum, product);
        Console.WriteLine();
    }
}
