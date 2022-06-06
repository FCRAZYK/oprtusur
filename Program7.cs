using System;
namespace V1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите месяц");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите год");
        int c = int.Parse(Console.ReadLine());
        if (((c % 4 == 0) && (c % 100 != 0) && (b == 2) && (a <= 29)) ||
            ((c % 4 == 0) && (c % 100 == 0) && (c % 400 == 0) && (b == 2) && (a <= 29)) ||
            ((c % 4 != 0) && (b == 2) && (a <= 28)) ||
                (((b == 1) || (b == 3) || (b == 5) || (b == 7) || (b == 8) || (b == 10) || (b == 12)) && (a <= 31)) ||
        (((b == 4) || (b == 6) || (b == 9) || (b == 11)) && (a <= 30)))
        {
            Console.WriteLine("Дата корректна");
        }
        else { Console.WriteLine("Дата некорректна"); }
        if (((c % 4 == 0) && (c % 100 != 0)) || ((c % 4 == 0) && (c % 100 == 0) && (c % 400 == 0)))
        {
            int[] array = { 0, 31, 60, 91, 121, 152, 183, 214, 244, 274, 305, 335, 366 };
            int i = b - 1;
            int d = array[i] + a;
            int p = 366 - h;
            Console.WriteLine($"{h} день с начала года");
            Console.WriteLine($"{os} осталось до окончания года");
        }
        else
        {
            int[] array = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365 };
            int i = y - 1;
            int d = array[i] + a;
            int p = 365 - h;
            Console.WriteLine($"{h} день с начала года");
            Console.WriteLine($"{os} осталось до окончания года");
        }
    }
}
