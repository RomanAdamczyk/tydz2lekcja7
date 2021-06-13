using System;

namespace tydz2lekcja7zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj rok");
            int num = Int32.Parse(Console.ReadLine());
            if (num % 4 == 0 && (num % 100 != 0 || num % 400 == 0))
            {
                Console.WriteLine($"{num} jest rokiem przestępnym");
            }
            else 
            {
                Console.WriteLine($"{num} nie jest rokiem przestępnym");
            }
        }
    }
}
