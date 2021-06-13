using System;

namespace tydz2lekcja7zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");
            int height = Int32.Parse(Console.ReadLine());
            if (height <= 0 )
            {
                Console.WriteLine("Nie ma Cię");
            }
            else if (height <= 90)
            {
                Console.WriteLine("Jesteś liliputem");
            }
            else if (height <= 140)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (height <= 165)
            {
                Console.WriteLine("Jesteś kurduplem");
            }
            else if (height <=175)
            {
                Console.WriteLine("Jesteś przeciętniakiem");
            }
            else if (height <= 220)
            {
                Console.WriteLine("Jesteś dryblasem");
            }
            else if (height <= 350)
            {
                Console.WriteLine("Jesteś olbrzymem");
            }
            else
            {
                Console.WriteLine("Jesteś gigantem");
            }
        }
    }
}
