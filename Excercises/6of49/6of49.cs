// TOTO 6/49

using System;

class Program
{
    static void Main()
    {
        long count = 0;
        for (int k = 1; k <= 44; k++)
        {
            for (int l = k + 1; l <= 45; l++)
            {
                for (int m = l + 1; m <= 46; m++)
                {
                    for (int o = m + 1; o <= 47; o++)
                    {
                        for (int p = o + 1; p <= 48; p++)
                        {
                            for (int q = p + 1; q <= 49; q++)
                            {
                                count++;
                                Console.WriteLine("{0} {1} {2} {3} {4} {5}", k, l, m, o, p, q);
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
