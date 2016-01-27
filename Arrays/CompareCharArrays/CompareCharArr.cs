//Problem 3. Compare char arrays
//
//Write a program that compares two char arrays lexicographically(letter by letter).

using System;

class CompareCharArr
{
    static void Main()
    {
        Console.Write("Enter the first word: ");
        string WordOne = Console.ReadLine();

        Console.Write("Enter the second word: ");
        string WordTwo = Console.ReadLine();

        int LenghtOne = WordOne.Length;
        int LenghtTwo = WordTwo.Length;
        int Lenght = Math.Min(LenghtOne, LenghtTwo);

        for (int i = 0; i < Lenght; i++)
        {
            if (WordOne[i] == WordTwo[i])
            {
                continue;
            }
            else if (WordOne[i] < WordTwo[i])
            {
                Console.WriteLine("\"{0}\" would appear before \"{1}\"", WordOne, WordTwo);
                return;
            }
            else
            {
                Console.WriteLine("\"{0}\" would appear before \"{1}\"", WordTwo, WordOne);
                return;
            }
        }
        if (LenghtOne == LenghtTwo)
        {
            Console.WriteLine("The words are with the same lenght.");
        }
        Console.WriteLine();
    }
}
