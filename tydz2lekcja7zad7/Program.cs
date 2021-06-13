using System;

namespace tydz2lekcja7zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            int num3 = Int32.Parse(Console.ReadLine());
            int max;
            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num3) 
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine($"{max} jest największa z podanych");

        }
    }
}
