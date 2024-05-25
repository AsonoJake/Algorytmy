using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy.Algorithms
{
    internal class Eratosthenes
    {
        public static double ErastothenesSolver(int n)
        {
            n = 100; // Zakres liczb do sprawdzenia

            Console.WriteLine("Liczby pierwsze w przedziale od 2 do " + n + ":");

            bool[] prime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                // Jeśli prime[p] jest true, to p jest liczbą pierwszą
                if (prime[p] == true)
                {
                    // Zaznacz wszystkie wielokrotności p jako false
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }

            for (int p = 2; p <= n; p++)
            {
                if (prime[p] == true)
                    Console.Write(p + " ");
            }
            Console.WriteLine();

            return 0;
        }
    }
}
