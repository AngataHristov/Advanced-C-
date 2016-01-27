// Problem 1. Decimal to binary
// 
// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
class DecimalBinary
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int Number = int.Parse(Console.ReadLine());
        if (Number != 0)
        {
            string binaryRepresentation = null;
            while (Number != 0)
            {
                int remainder = Number % 2;
                binaryRepresentation += remainder;
                Number /= 2;
            }
            Console.WriteLine(binaryRepresentation);
        }
        //Console.WriteLine(Convert.ToString(Number, 2));
    }
}
