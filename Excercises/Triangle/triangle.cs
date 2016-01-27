// 1
// 12
// 123
// 1234
// n....n

using System;

class triangle
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ",j);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    }
}
