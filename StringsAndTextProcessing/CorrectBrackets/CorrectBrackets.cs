// Problem 3. Correct brackets
// 
// Write a program to check if in a given expression the brackets are put correctly.

using System;
using System.Text;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter expression for checking: ");
        string expression = Console.ReadLine();
        int countBrackets = 0;
        if (expression[0] == ')' || expression[expression.Length - 1] == '(')
        {
            Console.WriteLine("Incorrect input!");
        }
        else
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    countBrackets++;
                }
                else if (expression[i] == ')')
                {
                    countBrackets--;
                }
                else
                {
                    continue;
                }
            }
            if (countBrackets == 0)
            {
                Console.WriteLine("Exoression is correct!");
            }
            else
            {
                Console.WriteLine("Expression is incorrect!");
            }
        }
    }
}
