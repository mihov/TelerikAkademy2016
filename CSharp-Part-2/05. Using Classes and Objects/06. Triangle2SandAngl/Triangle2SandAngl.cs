using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Triangle2SandAngl
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", CalcTriangle(a, b, angle));
    
    }

    static double CalcTriangle(double asideA, double asideB, double angle)
    {

    return asideA * asideB * Math.Sin(angle * Math.PI / 180) / 2.0;

    }
}
