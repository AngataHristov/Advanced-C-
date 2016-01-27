// Problem 6. First larger than neighbours
// 
// Write a method that returns the index of the first element in array that is 
// larger than its neighbours, or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;

class neighboursSize
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

    public static int CheckTheTwoNeighbours(int[] Arr)
    {
        int index = new int();

        for (int i = 1; i < Arr.Length - 1; i++)
        {
            if (Arr[i] > Arr[i - 1] && Arr[i] > Arr[i + 1])
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }
        return index;
    }

    public static void Main()
    {
        Console.Write("Enter the number of members in array: ");
        int n = int.Parse(Console.ReadLine());

        int[] Numbers = FillArray(n);

        Console.Write("The result is: ");
        int result = CheckTheTwoNeighbours(Numbers);
        Console.WriteLine(result);
        if (result > 0)
        {
            Console.WriteLine("The number on index {0} is: {1}", result, Numbers[result]);
        }
        Console.WriteLine();

    }
}