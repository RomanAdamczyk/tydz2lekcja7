using System;

namespace tydz2lekcja7zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę");
            int temp = Int32.Parse(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }
        }
    }
}

