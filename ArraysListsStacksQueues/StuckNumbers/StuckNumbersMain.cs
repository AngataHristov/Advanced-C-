namespace StuckNumbers
{
    using System;
    using System.Linq;

    public class StuckNumbersMain
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            bool areExist = false;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    for (int k = 0; k < count; k++)
                    {
                        for (int l = 0; l < count; l++)
                        {
                            string firstSum = input[i] + input[j];
                            string secondSum = input[k] + input[l];

                            bool areDiferent = input[i] != input[j] &&
                                               input[i] != input[k] &&
                                               input[i] != input[l] &&
                                               input[j] != input[k] &&
                                               input[j] != input[l] &&
                                               input[k] != input[l];

                            if (areDiferent && firstSum == secondSum)
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", input[i], input[j], input[k], input[l]);
                                areExist = true;
                            }
                        }
                    }
                }
            }

            if (!areExist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
