// Problem 5. Maximal increasing sequence
// 
// Write a program that finds the maximal increasing sequence in an array.

using System;

class IncreasingSequence
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
        int bestSequence = 0;
        int currentSequence = 0;
        int bestNum = 0;

        for (int i = 0; i < Numbers.Length - 1; i++)
        {
            if (Numbers[i] == Numbers[i + 1] - 1)
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
            Console.Write(" {0}", bestNum - bestSequence + 2);
            bestNum += 1;
            if (i < bestSequence - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine();
    }
}
