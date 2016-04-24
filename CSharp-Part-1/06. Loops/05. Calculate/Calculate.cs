using System;

class Calculate
{
    static void Main(string[] args)
    {
        ulong n = ulong.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        ulong factorial = 1;
        double sum = 1 + 1 / x;

        for (ulong counter = 2; counter <= n; counter++)
        {
            factorial = factorial * counter;
            double pow = Math.Pow(x, counter);
            sum = sum + (factorial / pow);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}
