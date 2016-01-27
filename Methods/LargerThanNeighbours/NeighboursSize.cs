// Problem 5. Larger than neighbours
// 
// Write a method that checks if the element at given position in given array of integers 
// is larger than its two neighbours(when such exist).

using System;

class NeighboursSize
{
    public static int[] FillArray(int n)
    {
        int[] Arr = new int[n];
        Console.WriteLine("Enter the members of the array:");

        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = int.Parse(Console.ReadLine());
        }
        return Arr;
    }

    public static void CheckTheTwoNeighbours(int position, int[] Arr)
    {
        if (Arr[position] > Arr[position - 1] && Arr[position] > Arr[position + 1])
        {
            Console.WriteLine("{0} in position {1} is larger than {2} and {3}.", Arr[position], position, Arr[position - 1], Arr[position + 1]);

        }
        else
        {
            Console.WriteLine("This case not exist!");
        }
    }

    public static void Main()
    {
        Console.Write("Enter the number of members in array: ");
        int n = int.Parse(Console.ReadLine());

        int[] Numbers = FillArray(n);

        Console.Write("Enter the posotion of number in array for checking (1~{0}): ", n - 2);
        int position = int.Parse(Console.ReadLine());

        CheckTheTwoNeighbours(position, Numbers);
        Console.WriteLine();
    }
}

