using System;

namespace tydz2lekcja7zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ocenę");
            int grad = Int32.Parse(Console.ReadLine());
            switch (grad)
            {
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczjący");
                    break;
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                default:
                    Console.WriteLine("Podano błędną ocenę");
                    break;
            }
        }
    }
}
