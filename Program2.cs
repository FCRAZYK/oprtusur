using System;
namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("y");
            int y = int.Parse(Console.ReadLine());
            if (a <= x && b <= y || b <= x && a <= y || a <= x && c <= y || c <= x && a <= y || c <= x && b <= y || b <= x && c <= y)
            {
                Console.WriteLine(true);
            }
            else
                Console.WriteLine(false);
        }
    }
}
