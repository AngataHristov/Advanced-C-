// Problem 8. Maximal sum
// 
// Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter the array lenght: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] Numbers = new int[arrLenght];
        Console.WriteLine("Enter {0} mebners of array:", arrLenght);

        for (int i = 0; i < arrLenght; i++)
        {
            Numbers[i] = int.Parse(Console.ReadLine());
        }
        int startIndex = 0;
        int currentSum = 0;
        int bestSum = int.MinValue;
        int bestStart = 0;
        int bestEnd = 0;

        for (int i = 0; i < Numbers.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }
            currentSum += Numbers[i];
            if (currentSum >= bestSum)
            {
                bestSum = currentSum;
                bestStart = startIndex;
                bestEnd = i;
            }
        }
        for (int i = bestStart; i <= bestEnd; i++)
        {
            Console.Write(i != bestEnd ? Numbers[i] + ", " : Numbers[i] + "\n");
        }
    }
}
