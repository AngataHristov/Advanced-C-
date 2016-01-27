// Problem 14. Integer calculations
// 
// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;

class IntCalculation
{
    public static double FindMin(params double[] Arr)
    {
        double min = Arr[0];
        for (int i = 0; i < Arr.Length; i++)
        {
            if (Arr[i] <= min)
            {
                min = Arr[i];
            }
        }
        return min;
    }
    public static double FindMax(params double[] Arr)
    {
        double max = Arr[0];
        for (int i = 0; i < Arr.Length; i++)
        {
            if (Arr[i] >= max)
            {
                max = Arr[i];
            }
        }
        return max;
    }
    public static double FindSum(params double[] Arr)
    {
        double sum = 0;
        for (int i = 0; i < Arr.Length; i++)
        {
            sum += Arr[i];
        }
        return sum;
    }
    public static double FindAverage(params double[] Arr)
    {
        double sum = FindSum(Arr);
        double average = (double)sum / Arr.Length;
        return average;
    }
    public static double FindProduct(params double[] Arr)
    {
        double product = 1;
        for (int i = 0; i < Arr.Length; i++)
        {
            product *= Arr[i];
        }
        return product;
    }
    public static void Main()
    {
        Console.Write("Enter the number of the members: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            double[] Arr = new double[n];
            Console.WriteLine("Enter the members of the array:");

            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The min number is {0}", FindMin(Arr));
            Console.WriteLine("The max number is {0}", FindMax(Arr));
            Console.WriteLine("The sum is {0}", FindSum(Arr));
            Console.WriteLine("The average is {0}", FindAverage(Arr));
            Console.WriteLine("The product is {0}", FindProduct(Arr));
            Console.WriteLine();
        }
    }
    }

