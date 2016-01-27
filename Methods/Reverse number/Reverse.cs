// Problem 7. Reverse number
// 
// Write a method that reverses the digits of given decimal number.

using System;

class Reverse
{
    public static void ReverseNumber(string number)
    {
        char[] Arr = new char[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            Arr[i] = number[i];
        }
        Array.Reverse(Arr);
        PrintArray(Arr);
    }

    public static void PrintArray(char[] arr)
    {
        Console.Write("The reversed number is: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
    }

    public static void Main()
    {
        Console.Write("Enter number for reverse: ");
        string Number = Console.ReadLine();
        ReverseNumber(Number);
        Console.WriteLine();
    }
}
