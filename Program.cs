using Algorytmy.Algorithms;

namespace Algorytmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Algorytmy");
                Console.WriteLine();
                Console.WriteLine("Witaj w programie do rozwiazywania algorytmow. Ponizej znajduje sie lista algorytmow obslugiwanych przez ten program.");
                Console.WriteLine();
                Console.WriteLine("1. Rozwiazanie rownania szescinnego");
                Console.WriteLine("2. Algorytm sito Eratostenesa");
                Console.WriteLine("3. Rozwiazanie wielomianu 5 stopnia");
                Console.WriteLine("4. Algorytm Monte Carlo");
                Console.WriteLine("5. Algorytm Ewolucyjny");
                Console.WriteLine();
                int choice = ReadIntFromConsole();

                // Wybór algorytmu
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Rozwiazanie rownania szescinnego");
                        Console.WriteLine("Rownanie szescienne ma postac: a*x^3 + b*x^2 + c*x + d = 0");
                        Console.WriteLine();
                        Console.Write("Wypisz zmienne po spacji");

                        // Wywołanie funkcji
                        double solution = CubicEquation.CubicEquationSolver(0, 0, 0, 0);

                        if (!double.IsNaN(solution))
                        {
                            Console.WriteLine("Rozwiązanie równania sześcinnego: x = " + solution);
                        }
                        else
                        {
                            Console.WriteLine("Nie znaleziono rozwiązania w danej liczbie iteracji.");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        // Wywołanie funkcji
                        Eratosthenes.ErastothenesSolver(100);
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    default:
                        Console.WriteLine("Nieprawidlowy wybor. Sprobuj ponownie wybrac numer algorytmu");
                        Console.ReadKey();
                        break;

                }
            } 
        }

        static int ReadIntFromConsole()
        {
            int result;
            string input;
            while (true)
            {
                Console.Write("Aby przejsc dalej wybierz numer: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    break;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
