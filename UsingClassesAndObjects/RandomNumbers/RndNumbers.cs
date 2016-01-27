// Problem 2. Random numbers
// 
// Write a program that generates and prints to the console 10 random values in the range[100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RndNumbers
{
    static void Main()
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            int randomNumber = rnd.Next(100, 201);
            Console.WriteLine("Random number {0}:{1}", i + 1, randomNumber);
        }
        Console.WriteLine();
    }
}
