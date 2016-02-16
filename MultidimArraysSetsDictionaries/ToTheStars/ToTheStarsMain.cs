namespace ToTheStars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ToTheStarsMain
    {
        public static void Main()
        {
            Dictionary<string, Tuple<double, double>> starSystemDictionary = new Dictionary<string, Tuple<double, double>>();

            for (int i = 0; i < 3; i++)
            {
                string[] starSystenTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string starSystemName = starSystenTokens[0];
                double starSystemCoordinateX = double.Parse(starSystenTokens[1]);
                double starSystemCoordinateY = double.Parse(starSystenTokens[2]);

                starSystemDictionary[starSystemName] = new Tuple<double, double>(starSystemCoordinateX, starSystemCoordinateY);
            }

            double[] spaceshipStartCoordinater = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

            int numberOfMoves = int.Parse(Console.ReadLine());
            double spaceshipX = spaceshipStartCoordinater[0];
            double spaceshipY = spaceshipStartCoordinater[1];


            while (numberOfMoves >= 0)
            {
                bool isInStarSystem = false;

                foreach (var pair in starSystemDictionary)
                {
                    if (IsInStarSystem(pair.Value.Item1, pair.Value.Item2, spaceshipX, spaceshipY))
                    {
                        Console.WriteLine(pair.Key.ToLower());

                        isInStarSystem = true;

                        break;
                    }
                }

                if (!isInStarSystem)
                {
                    Console.WriteLine("space");
                }

                spaceshipY++;
                numberOfMoves--;
            }
        }

        private static bool IsInStarSystem(double starX, double starY, double spaceshipX, double spaceshipY)
        {
            return ((spaceshipX >= starX - 1 && spaceshipX <= starX + 1) &&
                    (spaceshipY >= starY - 1 && spaceshipY <= starY + 1));
        }
    }
}
