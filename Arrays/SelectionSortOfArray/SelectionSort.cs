// Problem 7. Selection sort
// 
// Sorting an array means to arrange its elements in increasing order.Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the
// smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter the number of the elements in array: ");
        int N = int.Parse(Console.ReadLine());

        int[] Numbers = new int[N];
        Console.WriteLine("Enter the members int array:");

        for (int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < Numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < Numbers.Length; j++)
            {
                if (Numbers[i] >= Numbers[j])
                {
                    int Num = Numbers[i];
                    Numbers[i] = Numbers[j];
                    Numbers[j] = Num;
                }
            }
        }
        for (int i = 0; i < Numbers.Length; i++)
        {
            Console.Write("{0} ", Numbers[i]);
        }
        Console.WriteLine();
    }
}

