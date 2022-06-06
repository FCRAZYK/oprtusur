using System;
namespace Sample077
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int c = 0;
            while (a != 0)
            {
                if ((a % 10) % 2 == 0)
                {
                    c++;
                }
                a = a / 10;
            }
            Console.WriteLine("Количество четных цифр: {0}", c);
        }
    }
}
