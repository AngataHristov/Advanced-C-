//Problem 4. Maximal sequence
//
//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;

class MaxSequence
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
        int bestSequence = 1;
        int currentSequence = 0;
        int bestNum = 0;

        for (int i = 0; i < Numbers.Length - 1; i++)
        {
            if (Numbers[i] == Numbers[i + 1])
            {
                currentSequence++;
            }
            else
            {
                currentSequence = 1;
            }
            if (currentSequence >= bestSequence)
            {
                bestSequence = currentSequence;
                bestNum = Numbers[i];
            }
        }
        Console.Write("The max sequence is:");
        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write(" {0}", bestNum);
            if (i < bestSequence - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine();
    }
}

