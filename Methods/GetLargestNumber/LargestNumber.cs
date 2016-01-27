// Problem 2. Get largest number
// 
// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()

using System;

class LargestNumber
{
    public static int GetMax(int FirstNumber, int SecondNumber)
    {
        int LargerNumber = Math.Max(FirstNumber, SecondNumber);
        return LargerNumber;
    }
    public static void Main()
    {
        Console.WriteLine("Enter three integer numbers:");
        Console.Write("Enter first number: ");
        int FirstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int SecondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int ThirdNumber = int.Parse(Console.ReadLine());

        int maxNumber = GetMax(FirstNumber, SecondNumber);

        if (maxNumber >= GetMax(FirstNumber, ThirdNumber))
        {
            Console.WriteLine("The max number is: " + maxNumber);
        }
        else
        {
            Console.WriteLine("The max number is: " + GetMax(FirstNumber, ThirdNumber));
        }
        Console.WriteLine();
    }
}
