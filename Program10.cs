double s = double.Parse(Console.ReadLine());
for (int i = 1; i < 500; i++)
{
    for (int j = 1; j < 500; j++)
    {
        double s1 = (i * j) / 2;
        double gip = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
        if (gip == Math.Truncate(gip) && (s1 < s))
        {
            Console.WriteLine($"a={i}, b={j}, c={gip}, s={s1}");
        }
    }
}
