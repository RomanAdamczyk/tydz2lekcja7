using System;

namespace tydz2lekcja7zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długości boków trójkąta");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
        }
    }
}
