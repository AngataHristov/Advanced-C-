//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 2 integers from the console and prints the largest
//of them using the method GetMax().

namespace BiggerNumber
{
    using System;

    public class BiggerNumberMain
    {
        public static void Main()
        {
            Console.Write("Enter first  integer number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter first  integer number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int largerNumber = GetMax(firstNumber, secondNumber);

            Console.WriteLine("The bigger number is: {0}", largerNumber);
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            int largerNumber = firstNumber;

            if (secondNumber > firstNumber)
            {
                largerNumber = secondNumber;
            }

            return largerNumber;
        }
    }
}
