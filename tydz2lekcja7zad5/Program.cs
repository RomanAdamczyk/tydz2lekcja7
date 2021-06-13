using System;

namespace tydz2lekcja7zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wiek");
            int age = Int32.Parse(Console.ReadLine());
            if (age >= 35)
            {
                Console.WriteLine("Możesz zostać na posłem, senatorem lub przezydentem");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Możesz zostać na posłem lub senatorem");
            }
            else if (age >= 21)
            {
                Console.WriteLine("Możesz zostać na posłem");
            }
            else
            {
                Console.WriteLine("Nie masz biernych praw wyborczych");
            }
        }
    }
}
