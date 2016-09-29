using System;

namespace Flogex.CalculatePi
{
    class CalculatePi
    {
        public static double CalculateByChance (int squareSideLength , int iterations)
        {
            double pointsInCircle = 0;
            double totalPoints = 0;
            Random random = new Random();

            for (int i = 0; i < iterations; i++)
            {
                int randomX = random.Next(squareSideLength);
                int randomY = random.Next(squareSideLength);
                double distance = Math.Sqrt(Math.Pow(randomX - squareSideLength / 2 , 2) +
                    Math.Pow(randomY - squareSideLength / 2 , 2));
                if (distance <= squareSideLength / 2)
                {
                    pointsInCircle++;
                }
                totalPoints++;
            }
            return pointsInCircle * 4 / totalPoints;
        }
    }
}
