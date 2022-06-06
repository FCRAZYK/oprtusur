using System;
namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ct");
            int Ct = int.Parse(Console.ReadLine());
            Console.WriteLine("Ck");
            int Ck = int.Parse(Console.ReadLine());
            Console.WriteLine("Kt");
            int Kt = int.Parse(Console.ReadLine());
            Console.WriteLine("Kk");
            int Kk = int.Parse(Console.ReadLine());
            int S = Ct * Kt + Ck * Kk;
            Console.WriteLine(S);
        }
    }
}
