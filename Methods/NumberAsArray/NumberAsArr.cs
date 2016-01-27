// Problem 8. Number as array
// 
// Write a method that adds two positive integer numbers represented as arrays
// of digits(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;

class NumberAsArr
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
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
    }

    public static void Main()
    {
        Console.Write("Enter the first number: ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter the first number: ");
        string secondNumber = Console.ReadLine();

        Console.Write("The first number is: ");
        ReverseNumber(firstNumber);
        Console.WriteLine();
  
        Console.Write("The second number is: ");
        ReverseNumber(secondNumber);
        Console.WriteLine();
    }
}
