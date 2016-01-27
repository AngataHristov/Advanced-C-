//Problem 2. Binary to decimal
//
//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string Number = Console.ReadLine();
        int[] intNumber = new int[Number.Length];
        int decimalRepr = new int();
        for (int i = 0; i < Number.Length; i++)
        {
            intNumber[i] = Convert.ToInt16(Number[i]);
        }
        int Lenght = intNumber.Length;
        for (int i = 0; i < Number.Length; i++)
        {
            int member = intNumber[i] * (2 ^ ((Lenght - 1) - i));
            decimalRepr += member;
        }
        Console.WriteLine(decimalRepr);
    }
}
