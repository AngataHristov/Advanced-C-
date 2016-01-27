// Problem 4. Binary search
// 
// Write a program, that reads from the console an array of N integers and an integer K,
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinSearch
{
    static void Main()
    {
        Console.Write("Enter the number ot the integers \"n\": ");
        int numberInt = int.Parse(Console.ReadLine());
        Console.Write("Enter integer \"k\": ");
        int k = int.Parse(Console.ReadLine());

        string[] arr = new string[numberInt];
        Console.Write("Enter \"n\" members, separate by space:");

        arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(arr);
        Console.Write("The sorted array is: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = Convert.ToInt32(arr[i]);
        }
        int index = Array.BinarySearch(newArr, k);
        Console.WriteLine();

        if (index==-1)
        {
            Console.WriteLine("The entered number miss in the sequence!");
        }
        else
        {
            Console.WriteLine("The largest number in the array which is <= K: {0}", newArr[index]);
        }
        Console.WriteLine();
    }
}
