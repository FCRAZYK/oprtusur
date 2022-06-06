using System;
namespace Sample077
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                x *= x;
            }
            Console.WriteLine(x);
        }
    }
}
