using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double temp = b;
            b = a;
            a = temp;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}