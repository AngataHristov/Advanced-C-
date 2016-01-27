// Problem 3. English digit
// 
// Write a method that returns the last digit of given integer as an English word.

using System;

class Digit
{
    public static string DigitToWord(char digit)
    {
        string DigitName;
        switch (digit)
        {
            case '0':
                DigitName = "Zero";
                break;
            case '1':
                DigitName = "One";
                break;
            case '2':
                DigitName = "Two";
                break;
            case '3':
                DigitName = "Three";
                break;
            case '4':
                DigitName = "Four";
                break;
            case '5':
                DigitName = "Five";
                break;
            case '6':
                DigitName = "Six";
                break;
            case '7':
                DigitName = "Seven";
                break;
            case '8':
                DigitName = "Eight";
                break;
            case '9':
                DigitName = "Nine";
                break;
            default:
                Console.WriteLine("Invalid input!");
                return null;
        }
        return DigitName;
    }
    public static void Main()
    {
        Console.Write("Enter integer number: ");
        string Number = Console.ReadLine();
        char lastDigit = Number[Number.Length - 1];
        Console.Write("The english word of {0} is \"{1}\".", lastDigit, DigitToWord(lastDigit));
        Console.WriteLine();
    }
}
