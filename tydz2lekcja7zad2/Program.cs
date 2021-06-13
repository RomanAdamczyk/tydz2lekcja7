using System;

namespace tydz2lekcja7zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int num = Int32.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{num} jest liczbą nieparzystą");
            }
        }
    }
}
