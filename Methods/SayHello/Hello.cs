// Problem 1. Say Hello
// 
// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;

class Hello
{
    public static void PrintName()
    {
        Console.Write("Enter your name: ");
        string Name = Console.ReadLine();
        Console.WriteLine("Hello, " + Name+ "!");
    }
    public static void Main()
    {
        PrintName();
        Console.WriteLine();
    }
}
