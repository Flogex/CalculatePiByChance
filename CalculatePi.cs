using System;

namespace Flogex.MonteCarlo
{
    class CalculatePi
    {
        public static double Run (int iterations)
        {
            double pointsInCircle = 0;
            double totalPoints = 0;
            Random random = new Random();

            for (int i = 0; i < iterations; i++)
            {
                double randomX = random.NextDouble();
                double randomY = random.NextDouble();
                double distance = Math.Sqrt(Math.Pow(randomX - 0.5, 2) + Math.Pow(randomY - 0.5, 2));
                if (distance <= 0.5)
                {
                    pointsInCircle++;
                }
                totalPoints++;
            }
            return pointsInCircle * 4 / totalPoints;
        }
    }
}
