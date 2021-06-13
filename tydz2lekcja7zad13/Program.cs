using System;

namespace tydz2lekcja7zad13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer operacji do wykonania");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            int choose = Int32.Parse(Console.ReadLine());
            double result;
            switch (choose)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Twój wynik to {result}");
                    }
                    else
                    {
                        Console.WriteLine("Nie dziel przez 0");
                    }
                    break;

            }
        }
    }
}
