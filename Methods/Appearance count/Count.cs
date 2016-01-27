// Problem 4. Appearance count
// 
// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly

using System;

class Count
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
    public static void CheckNumber(int number, int[] Arr)
    {
        int counter = 0;

        for (int i = 0; i < Arr.Length; i++)
        {
            if (number == Arr[i])
            {
                counter++;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("{0} appears {1} times in the array", number, counter);
    }
    public static void Main()
    {
        Console.Write("Enter the number of members in array: ");
        int n = int.Parse(Console.ReadLine());

        int[] Numbers = FillArray(n);

        Console.Write("Enter the number for checking: ");
        int k = int.Parse(Console.ReadLine());

        CheckNumber(k, Numbers);
        Console.WriteLine();
    }
}
