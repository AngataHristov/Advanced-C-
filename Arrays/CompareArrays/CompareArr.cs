//Problem 2. Compare arrays
//
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArr
{
    static void Main()
    {
        Console.Write("Enter array1 lenght: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter array2 lenght: ");
        int m = int.Parse(Console.ReadLine());

        int[] arrOne = new int[n];
        int[] arrTwo = new int[m];
        bool IsEqual = true;

        if (n!=m)
        {
            Console.WriteLine("Different size of the arrays!");
        }
        else
        {
            Console.WriteLine("Enter the members of arr1: ");
            for (int i = 0; i < n; i++)
            {
                arrOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the members of arr2: ");
            for (int i = 0; i < m; i++)
            {
                arrTwo[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (arrOne[i] != arrTwo[i])
                {
                    IsEqual = false;
                }
            }
            Console.WriteLine("ArrOne = ArrTwo is: {0}", IsEqual);
        }
    }
}
