using System;


class Triangle3sides
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", CalcTriangle(a, b, c));
    }

    static double CalcTriangle(double asideA, double asideB, double asideC)
    {
        double p = (asideA + asideB + asideC) / 2.0;

        return Math.Sqrt(p * (p - asideA) * (p - asideB) * (p - asideC));


    }
}

