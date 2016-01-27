// Problem 13. Solve tasks
// 
// Write a program that can solve these tasks:
// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a* x + b = 0

using System;

class SolveTasks
{
    public static char[] ReverseDigitsOfNumber(string number)
    {
        char[] Arr = new char[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            Arr[i] = number[i];
        }
        Array.Reverse(Arr);
        return Arr;
    }
    public static void PrintReversedNumber(string num)
    {
        char[] arr = ReverseDigitsOfNumber(num);
        Console.Write("The reversed number is: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}", arr[i]);
        }
        Console.WriteLine();
    }
    public static double[] FillSequence(int length)
    {
        double[] sequence = new double[length];
        Console.Write("Enter the members of the sequence, splited by \" \". ");
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (input.Length != length)
        {
            Console.WriteLine("Invalid input! The entered member are not={0}", length);
        }
        else
        {
            for (int i = 0; i < input.Length; i++)
            {
                sequence[i] = double.Parse(input[i]);
            }
        }
        return sequence;
    }
    public static double AverageOfASequenceOfIntegers(int n)
    {
        double[] arr = FillSequence(n);
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        double average = (double)sum / arr.Length;
        return average;
    }
    public static void SolveLinearEquation(double a, double b)
    {
        if (a == 0)
        {
            Console.WriteLine("Invalid input! a must be !=0");
        }
        else
        {
            double result = (double)-(b) / (a);
            Console.WriteLine("The result of {0}*x+{1} = {2}", a, b, result);
        }
    }
    public static void ChooseSolve(int number)
    {
        switch (number)
        {
            case 1:
                Console.Write("Enter number for reverse: ");
                string num = Console.ReadLine();
                PrintReversedNumber(num);
                break;
            case 2:
                Console.Write("Enter the number of members: ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Invalid input! Enter number >= 0!");
                }
                else
                {
                    double result = AverageOfASequenceOfIntegers(n);
                    Console.WriteLine("The average sum of the sequense's members is {0}", result);
                }
                break;
            case 3:
                Console.Write("Enter a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                double b = double.Parse(Console.ReadLine());
                SolveLinearEquation(a, b);
                break;
            default:
                break;
        }
    }
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Choose from the menu and write the number of the task for solve:\"1\",\"2\",\"3\".");
        Console.WriteLine("\"1\" for reversing the digits of number.");
        Console.WriteLine("\"2\" for calculating the average of a sequence of integers.");
        Console.WriteLine("\"3\" for solving a linear equation a* x + b = 0.");
        int numberOfSolve = int.Parse(Console.ReadLine());
        if (numberOfSolve == 1 || numberOfSolve == 2 || numberOfSolve == 3)
        {
            ChooseSolve(numberOfSolve);
        }
        else
        {
            Console.WriteLine("Invalid input! Choose one of the given options!");
        }
        Console.WriteLine(":)");
    }
}
