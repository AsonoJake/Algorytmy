using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy.Algorithms
{
    internal class Bisection
    {
        public static double BisectionMethod(Func<double, double> func, double left, double right, double tolerance, double a, double b, double c, double d, double e, double f)
        {
            Func<double, double> polynomial = (x) =>
            a * Math.Pow(x, 5) +
            b * Math.Pow(x, 4) +
            c * Math.Pow(x, 3) +
            d * Math.Pow(x, 2) +
            e * x +
            f;

            // Sprawdzenie, czy funkcja zmienia znak na końcach przedziału
            if (func(left) * func(right) >= 0)
            {
                throw new ArgumentException("Funkcja musi zmieniać znak na końcach przedziału [left, right]");
            }

            double mid = left;

            // Liczenie pierwiastka
            while ((right - left) / 2.0 > tolerance)
            {
                mid = (left + right) / 2.0;
                if (func(mid) == 0.0)
                {
                    break; // Znaleziono dokładny pierwiastek
                }
                else if (func(left) * func(mid) < 0)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }

            return mid;
        }
    }
}
