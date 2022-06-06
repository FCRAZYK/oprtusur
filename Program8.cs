using System;
namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное число ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Количество попыток ");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int k = r.Next(1, number);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите своё число - ");
                int t = int.Parse(Console.ReadLine());
                if (i == n - 1)
                {
                    Console.WriteLine("У вас закончилось число попыток");
                    break;
                }

                if (t == k)
                {
                    Console.WriteLine("You win");
                    break;
                }
                else
                {
                    if (t > k)
                        Console.WriteLine("the number is greater");
                    if (t < k)
                        Console.WriteLine("the number is less");
                }

            }

        }
    }
}
