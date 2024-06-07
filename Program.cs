using Algorytmy.Algorithms;

namespace Algorytmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
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
                Console.WriteLine("5. Problem Komiwojazera");
                Console.WriteLine();
                int choice = ReadIntFromConsole();

                // Wybór algorytmu
                switch (choice)
                {
                    case 1:
                        do {
                            // Ustawianie zmiennych
                            Console.Clear();
                            Console.WriteLine("Rozwiazanie rownania szescinnego");
                            Console.WriteLine("Rownanie szescienne ma postac: a*x^3 + b*x^2 + c*x + d = 0");
                            Console.WriteLine();
                            Console.Write("Wypisz zmienne po spacji: ");
                            string input = Console.ReadLine();
                            if (input == "exit") break;
                            if (input == "") break;

                            int maxIterations = 1000;
                            double a, b, c, d, x0 = 0.0, epsilon = 1e-6;
                            bool check = double.TryParse(input.Split(' ')[0], out a), check2 = double.TryParse(input.Split(' ')[1], out b), check3 = double.TryParse(input.Split(' ')[2], out c), check4 = double.TryParse(input.Split(' ')[3], out d);

                            // Sprawdzanie poprawnosci wprowadzonych danych
                            if (!check || !check2 || !check3 || !check4)
                            {
                                Console.WriteLine("Nieprawidlowe dane.");
                                Console.ReadKey();
                                break;
                            }

                            Console.WriteLine();
                            Console.WriteLine("Podaj poczatkowe przyblizenie rozwiazania");
                            Console.WriteLine("Domyslne to 0.0");
                            Console.WriteLine();
                            Console.Write("Podaj wartosc: ");
                            input = Console.ReadLine();

                            check = double.TryParse(input, out x0);

                            // Sprawdzanie poprawnosci wprowadzonych danych
                            if (!check)
                            {
                                Console.WriteLine("Nieprawidlowe dane.");
                                Console.ReadKey();
                                break;
                            }

                            Console.WriteLine();
                            Console.WriteLine("Podaj oczekiwana dokladnosc");
                            Console.WriteLine("Domyslne to 1e-6");
                            Console.WriteLine();
                            Console.Write("Podaj wartosc: ");
                            input = Console.ReadLine();

                            check = double.TryParse(input, out epsilon);

                            // Sprawdzanie poprawnosci wprowadzonych danych
                            if (!check)
                            {
                                Console.WriteLine("Nieprawidlowe dane.");
                                Console.ReadKey();
                                break;
                            }

                            Console.WriteLine();
                            Console.WriteLine("Podaj ilosc iteracji");
                            Console.WriteLine("Domyslne to 1000");
                            Console.WriteLine();
                            Console.Write("Podaj wartosc: ");
                            input = Console.ReadLine();

                            check = int.TryParse(input, out maxIterations);

                            // Sprawdzanie poprawnosci wprowadzonych danych
                            if (!check)
                            {
                                Console.WriteLine("Nieprawidlowe dane.");
                                Console.ReadKey();
                                break;
                            }

                            // Wywołanie funkcji
                            double solution = CubicEquation.CubicEquationSolver(a, b, c, d, x0, epsilon, maxIterations);

                            Console.Clear();
                            Console.WriteLine($"Twoje rownanie szescienne to {a}*x^3 + {b}*x^2 + {c}*x + {d} = 0");
                            if (!double.IsNaN(solution))
                            {
                                Console.WriteLine("Rozwiazanie rownania szescinnego: x = " + solution);
                            }
                            else
                            {
                                Console.WriteLine("Nie znaleziono rozwiazania w danej liczbie iteracji.");
                            }
                            Console.WriteLine("Nacisnij dowolny klawisz aby kontynuowac...");
                            Console.ReadKey();
                            break;
                        } while (true);
                        break;
                    case 2:
                        do
                        {
                            // Ustawianie zmiennych
                            Console.Clear();
                            Console.WriteLine("Algorytm sito Eratostenesa");
                            Console.WriteLine();
                            Console.Write("Wypisz liczbe koncowa (tylko int)!");
                            choice = ReadIntFromConsole();

                            // Wywołanie funkcji
                            Eratosthenes.ErastothenesSolver(choice);
                            break;
                        } while (true);
                        break;
                    case 3:
                        do
                        {
                            // Ustawianie zmiennych
                            Console.Clear();
                            Console.WriteLine("Rozwiazanie wielomianu 5 stopnia");
                            Console.WriteLine("Rownanie szescienne ma postac: a*x^5 + b*x^4 + c*x^3 + d*x^2 + e*x + f = 0");
                            Console.WriteLine();
                            Console.Write("Wypisz zmienne po spacji: ");
                            string input = Console.ReadLine();
                            if (input == "exit") break;
                            if (input == "") break;

                            int maxIterations = 1000;
                            double a, b, c, d, e, f, x0 = -10, x1 = 10, epsilon = 1e-6;
                            bool check = double.TryParse(input.Split(' ')[0], out a), check2 = double.TryParse(input.Split(' ')[1], out b), check3 = double.TryParse(input.Split(' ')[2], out c), check4 = double.TryParse(input.Split(' ')[3], out d), check5 = double.TryParse(input.Split(' ')[4], out e), check6 = double.TryParse(input.Split(' ')[5], out f);

                            // Sprawdzanie poprawnosci wprowadzonych danych
                            if (!check || !check2 || !check3 || !check4 || !check5 || !check6)
                            {
                                Console.WriteLine("Nieprawidlowe dane.");
                                Console.ReadKey();
                                break;
                            }

                            Console.WriteLine();
                            Console.WriteLine("Podaj min oraz max funkcji");
                            Console.WriteLine();
                            Console.Write("Podaj wartosci po spacji: ");
                            input = Console.ReadLine();

                            check = double.TryParse(input.Split(' ')[0], out x0);
                            check2 = double.TryParse(input.Split(' ')[1], out x1);

                            // Sprawdzanie poprawnosci wprowadzonych danych
                            if (!check || !check2)
                            {
                                Console.WriteLine("Nieprawidlowe dane.");
                                Console.ReadKey();
                                break;
                            }

                            Console.WriteLine();
                            Console.WriteLine("Podaj oczekiwana dokladnosc");
                            Console.WriteLine("Domyslne to 1e-6");
                            Console.WriteLine();
                            Console.Write("Podaj wartosc: ");
                            input = Console.ReadLine();

                            check = double.TryParse(input, out epsilon);

                            // Sprawdzanie poprawnosci wprowadzonych danych
                            if (!check)
                            {
                                Console.WriteLine("Nieprawidlowe dane.");
                                Console.ReadKey();
                                break;
                            }

                            // Wywołanie funkcji
                            double solution = Bisection.BisectionMethod(a, b, c, d, e, f, x0, x1, epsilon);

                            Console.Clear();
                            if (!double.IsNaN(solution))
                            {
                                Console.WriteLine("Rozwiazanie rownania szescinnego: x = " + solution);
                            }
                            else
                            {
                                Console.WriteLine("Nie znaleziono rozwiazania");
                            }
                            Console.WriteLine("Nacisnij dowolny klawisz aby kontynuowac...");
                            Console.ReadKey();
                            break;
                        } while (true);
                        break;
                    case 4:
                        do
                        {
                            // Wywołanie funkcji i ustawienie zmiennych
                            MonteCarlo.MonteCarloMethod();
                            Console.WriteLine("Nacisnij dowolny klawisz aby kontynuowac...");
                            Console.ReadKey();
                            break;
                        } while (true);
                        break;
                    case 5:

                        break;
                    default:
                        Console.WriteLine("Nieprawidlowy wybor. Sprobuj ponownie wybrac numer algorytmu");
                        Console.ReadKey();
                        break;

                }
            } while (true);
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
