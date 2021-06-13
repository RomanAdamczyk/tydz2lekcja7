using System;

namespace tydz2lekcja7zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą zmienną");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą zmienną");
            int num2 = Int32.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} i {num2} są równe");
            }
            else
            {
                Console.WriteLine($"{num1} i {num2} nie są równe");
            }
        }
    }
}
