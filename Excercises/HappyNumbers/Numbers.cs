// A+B=C+D happy numbers , find it!

using System;

class Numbers
{
    static void Main()
    {
        for (int a = 1; a < 10; a++)
        {
            for (int b = 0; b < 10; b++)
            {
                for (int c = 0; c < 10; c++)
                {
                    for (int d = 0; d < 10; d++)
                    {
                        if (a + b == c + d)
                        {
                            Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}

