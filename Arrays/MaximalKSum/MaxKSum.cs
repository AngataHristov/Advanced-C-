// Problem 6. Maximal K sum
// 
// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class MaxKSum
{
    public static void Main()
    {
        Console.Write("Enter the number of the elements in array: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of the elements for sum: ");
        int K = int.Parse(Console.ReadLine());
        int[] Numbers = new int[N];

        if (K > N)
        {
            Console.WriteLine("Invalid input!");
        }

        Console.WriteLine("Enter the members int array:");

        for (int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < Numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < Numbers.Length; j++)
            {
                if (Numbers[i] <= Numbers[j])
                {
                    int Num = Numbers[i];
                    Numbers[i] = Numbers[j];
                    Numbers[j] = Num;
                }
            }
        }
        for (int i = 0; i < K; i++)
        {
            Console.Write("{0} ",Numbers[i]);
        }
        Console.WriteLine();
    }
}
