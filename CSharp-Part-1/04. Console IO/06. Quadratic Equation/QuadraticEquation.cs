using System;
using System.Globalization;
using System.Threading;


class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double sqrtpart = b * b - 4 * a * c;
        double x, x1, x2, img;

        if (sqrtpart > 0)
        {
            x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("{0:f2}\n{1:f2}", x2, x1);
        }
        else if (sqrtpart < 0)
        {
            sqrtpart = -sqrtpart;
            x = -b / (2 * a);
            img = System.Math.Sqrt(sqrtpart) / (2 * a);
            Console.WriteLine("no real roots");
        }
        else
        {
            x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("{0:f2}", x);
        }
    }
}
