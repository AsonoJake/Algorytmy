﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy.Algorithms
{
    internal class CubicEquation
    {
        public static double CubicEquationSolver(double a, double b, double c, double d, double x0, double epsilon, int maxIterations)
        {
            // Metoda Newtona-Raphsona
            for (int i = 0; i < maxIterations; i++)
            {
                double fx = (a * Math.Pow(x0, 3)) + (b * Math.Pow(x0, 2)) + (c * x0) + d;
                double fPrimeX = (3 * a * Math.Pow(x0, 2)) + (2 * b * x0) + c;

                // Aktualizacja przybliżenia rozwiązania
                double x1 = x0 - (fx / fPrimeX);

                // Sprawdzenie warunku stopu
                if (Math.Abs(x1 - x0) < epsilon)
                {
                    return x1;
                }

                x0 = x1;
            }

            // Jeśli nie znaleziono rozwiązania w danej liczbie iteracji
            return double.NaN;
        }
    }
}
