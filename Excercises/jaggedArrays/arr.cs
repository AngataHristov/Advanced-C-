using System;
using System.Collections.Generic;
using System.Linq;

class arr
{
    static void Main()
    {
        // int[][] numbers = new int[5][];
        // numbers[0] = new int[35];
        // numbers[1] = new int[4];

        // int[][] numbers = new int[5][];
        // for (int i = 1; i < numbers.Length; i++)
        // {
        //     numbers[i] = new int[i];
        // }

        int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
        int[][] remainders = new int[3][];
        int[] counter = new int[3];

        foreach (int number in numbers)
        {
            int currentRemainder = number % 3;
            counter[currentRemainder]++;
        }
        for (int i = 0; i < counter.Length; i++)
        {
            int currentCount = counter[i];
            remainders[i] = new int[currentCount];
        }
        int[] indexes = new int[3];
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            int remainder = currentNumber % 3;

            remainders[remainder][indexes[remainder]] = currentNumber;
            indexes[remainder]++;
        }
    }
}
