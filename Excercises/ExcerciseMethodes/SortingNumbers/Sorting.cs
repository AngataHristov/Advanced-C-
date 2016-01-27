using System;

class Sorting
{
    public static int[] Sort(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int num = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = num;
                }
            }
        }
        return numbers;
    }
    public static void PrintNumbers(params int[] numbers)
    {
        Console.Write("The sorted numbers are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}", numbers[i]);
            if (i <= numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }
    static void Main()
    {
        int[] numbers = new int[] {3,6,0,1,-2,-9};
        int[] SortedNumbers=Sort(numbers);
        PrintNumbers(SortedNumbers);
        Console.WriteLine();
    }
}

