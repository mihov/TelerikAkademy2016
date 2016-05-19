using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class TriangleBy_a_h
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());


        Console.WriteLine("{0:F2}", CalcTriangle(a, h));
    }

    static double CalcTriangle(double aside, double altitude)
    {
        return (aside * altitude) / 2;
    }
}