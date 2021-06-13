using System;

namespace tydz2lekcja7zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wynik z matematyki");
            int math = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z fizyki");
            int phys = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z chemii");
            int chem = Int32.Parse(Console.ReadLine());
            if ((math > 70 && phys > 55 && chem > 45 && math + phys + chem > 180) || (math + phys > 150 || math + chem > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }

        }
    }
}
