using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy.Algorithms
{
    internal class MonteCarlo
    {
        public static double MonteCarloMethod(int points)
        {
            // Definiowanie funkcji, dla której chcemy obliczyć pole pod wykresem
            Func<double, double> function = x =>
            Math.Sin(x); // Przykład: funkcja sinus

            // Zakresy, w których chcemy obliczyć pole pod wykresem
            double xMin = 0;
            double xMax = Math.PI;
            double yMin = 0;
            double yMax = 1;

            // Liczba punktów do wygenerowania w algorytmie Monte Carlo
            points = 1000000;

            // Licznik punktów znajdujących się pod wykresem funkcji
            int pointsUnderCurve = 0;

            // Obiekt do generowania liczb losowych
            Random random = new Random();

            // Generowanie losowych punktów i sprawdzanie, czy znajdują się pod wykresem funkcji
            for (int i = 0; i<points; i++)
            {
                double x = xMin + (xMax - xMin) * random.NextDouble();
                double y = yMin + (yMax - yMin) * random.NextDouble();

                if (y <= function(x))
                {
                    pointsUnderCurve++;
                }
            }

            // Obliczenie pola prostokąta obejmującego wykres funkcji
            double rectangleArea = (xMax - xMin) * (yMax - yMin);

            // Obliczenie pola pod wykresem funkcji
            double areaUnderCurve = (double)pointsUnderCurve / points * rectangleArea;

            Console.WriteLine($"Pole pod wykresem funkcji: {areaUnderCurve}");

            return 0;
        }
    }
}
