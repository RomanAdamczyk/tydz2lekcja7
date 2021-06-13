using System;

namespace tydz2lekcja7zad12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer dnia tygodnia");
            int num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("podaną błędną liczbę");
                    break;
            }
        }
    }
}
