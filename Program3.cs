using System;
namespace Sample077
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите кол-во элементов массива");
            n = int.Parse(Console.ReadLine());
            double[] kiwka = new double[n];
            Random rand = new Random();
            double max = kiwka[0];
            for (int i = 0; i < n; i++)
            {
                kiwka[i] = rand.Next(100);
            }
            double jegast;
            for (int i = 0; i < n; i++)
            {
                if (kiwka[i] > max)
                {
                    max = kiwka[i];
                }
            }
            jegast = max * 0.9;
            int ggg = 0;
            for (int i = 0; i < n; i++)
            {
                if (kiwka[i] < jegast)
                {
                    ggg++;
                }
            }
            int t = n - ggg;
            Console.WriteLine(t);
            Console.WriteLine(max);
            for (int i = 0; i < kiwka.Length; i++)
            {
                Console.Write(kiwka[i] + " ");
            }
        }
    }
}
