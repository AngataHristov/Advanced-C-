// Problem 9. Sorting array
// 
// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArr
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
    public static int FindMaxElement(int index, params int[] numbers)
    {
        int maxElement = int.MinValue;
        for (int i = index; i < numbers.Length; i++)
        {
            if (numbers[i] > maxElement)
            {
                maxElement = numbers[i];
            }
            else
            {
                continue;
            }
        }
        return maxElement;
    }
    public static int[] Sort(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int num = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = num;
                }
            }
        }
        return numbers;
    }
    public static void PrintNumbers(params int[] numbers)
    {
        Console.Write("The sorted numbers are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}", numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter the number of members in array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the position index: ");
        int index = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        if (index >= numbers.Length)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            numbers = FillArray(n);
            int maxElem = FindMaxElement(index, numbers);
            Console.WriteLine("The max element after elemen with index {0} is {1}", index, maxElem);
            int[] SortedNumbers = Sort(numbers);
            PrintNumbers(SortedNumbers);
            Console.WriteLine();
        }
    }
}
