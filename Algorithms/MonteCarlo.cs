using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy.Algorithms
{
    internal class MonteCarlo
    {
        public static double MonteCarloMethod()
        {
            Console.Clear();
            Console.WriteLine("Algorytm Monte Carlo");
            Console.WriteLine("Liczenie pola pod wykresem funkcji");
            Console.WriteLine();
            Console.WriteLine("1. Sin(x)");
            Console.WriteLine("2. Cos(x)");
            Console.WriteLine("3. x^2");
            Console.WriteLine("4. e^x");
            Console.Write("Wybierz funkcje, dla ktorej chcesz obliczyc pole pod wykresem: ");
            string input = Console.ReadLine();
            if (input == "exit") return 0;
            if (input == "") return 0;

            // Definiowanie funkcji, dla której chcemy obliczyć pole pod wykresem
            Func<double, double> function;
            double xMin, xMax, yMin, yMax;

            // Zakresy, w których chcemy obliczyć pole pod wykresem
            switch (input)
            {
                case "1":
                    function = x => Math.Sin(x);
                    xMin = 0;
                    xMax = Math.PI;
                    yMin = 0;
                    yMax = 1;
                    break;
                case "2":
                    function = x => Math.Cos(x);
                    xMin = 0;
                    xMax = Math.PI;
                    yMin = -1;
                    yMax = 1;
                    break;
                case "3":
                    function = x => x * x;
                    xMin = 0;
                    xMax = 1;
                    yMin = 0;
                    yMax = 1;
                    break;
                case "4":
                    function = x => Math.Exp(x);
                    xMin = 0;
                    xMax = 1;
                    yMin = 1;
                    yMax = Math.Exp(1);
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybor.");
                    Console.ReadKey();
                    return 0;
            }

            Console.Clear();
            Console.Write("Podaj ilosc rzutow: ");
            input = Console.ReadLine();

            // Liczba punktów do wygenerowania w algorytmie Monte Carlo
            int points = int.Parse(input);

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
