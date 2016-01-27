using System;

class Demo
{
    static void Main()
    {
        Random generator = new Random();
        for (int i = 1; i < 100; i++)
        {
            int rnd = generator.Next(1, 100);
            Console.WriteLine(rnd);
        }
    }
}
