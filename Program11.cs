using System;
namespace Currently
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B ");
            int B = int.Parse(Console.ReadLine());
            Program random = new Program();
            for (int i = 0; i < 100; i++)
            {
                Console.Write(random.Rand(A, B));
                Console.Write(" ");

            }

        }
        public int Rand(int A, int B)
        {
            Random rand = new Random();

            return rand.Next(A, B); ;
        }
    }
}
