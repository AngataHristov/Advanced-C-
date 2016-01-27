//Problem 1. Allocate array
//
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArr
{
    static void Main()
    {
        int[] IntArr = new int[20];
        for (int i = 0; i < IntArr.Length; i++)
        {
            IntArr[i] = i * 5;
            Console.Write(IntArr[i] + ", ");
        }

        Console.WriteLine();
       // Console.WriteLine(String.Join(", ", IntArr));
    }
}
