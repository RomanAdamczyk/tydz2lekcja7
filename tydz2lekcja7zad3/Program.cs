using System;

namespace tydz2lekcja7zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int num = Int32.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"{num} jest liczbą dodatnią");
            }
            else if (num <0)
            {
                Console.WriteLine($"{num} jest liczbą ujemną");
            }
            else
            {
                Console.WriteLine($"{num} jest zerem");
            }
        }
    }
}
