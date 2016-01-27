using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PassGenerator
{
    // static Random rndGenerator = new Random();
    // 
    // static void InsertRandomSymbols(int count, StringBuilder password, string symbols)
    // {
    //     for (int i = 0; i < count; i++)
    //     {
    //         char symbol = symbols[rndGenerator.Next(0, symbols.Length)];
    //         int randomPosition = rndGenerator.Next(0, password.Length);
    //         password.Insert(randomPosition, symbol);
    //     }
    // }
    // static void Main()
    // {
    //     string capitalLetters = "ABSDEFGHIJKLMNOPQRSTUVQXYZ";
    //     string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
    //     string digits = "0123456789";
    //     string specialSymbols = "~!@#$%^&*()_+";
    // 
    //     StringBuilder password = new StringBuilder();
    // 
    //     InsertRandomSymbols(2, password, capitalLetters);
    //     InsertRandomSymbols(2, password, lowerLetters);
    //     InsertRandomSymbols(1, password, digits);
    //     InsertRandomSymbols(3, password, specialSymbols);
    //     InsertRandomSymbols(rndGenerator.Next(0, 7), password, capitalLetters + lowerLetters + digits + specialSymbols);
    //     Console.WriteLine(password.ToString());
    // }
    static Random rndGenerator = new Random();

    public static void InsertRandomSymbol(int count, StringBuilder password, string symbols)
    {
        for (int i = 0; i < count; i++)
        {
            char symbol = symbols[rndGenerator.Next(0, symbols.Length)];
            int randomPosition = rndGenerator.Next(0, password.Length);
            password.Insert(randomPosition, symbol);
        }
    }
    public static void Main()
    {
        string capitalLetters = "ABSDEFGHIJKLMNOPQRSTUVQXYZ";
        string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
        string digits = "0123456789";
        string specialSymbols = "!@#$%^&*_+";

        StringBuilder password = new StringBuilder();
        InsertRandomSymbol(2, password, capitalLetters);
        InsertRandomSymbol(2, password, lowerLetters);
        InsertRandomSymbol(1, password, digits);
        InsertRandomSymbol(3, password, specialSymbols);
        InsertRandomSymbol(rndGenerator.Next(0, 7), password, capitalLetters + lowerLetters + digits + specialSymbols);
        Console.WriteLine(password.ToString());
    }
}

