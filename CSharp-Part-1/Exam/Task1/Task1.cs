using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double t = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());

        double result = t * b * s * n;

        if (((int)(result % 2)) == 0)
        {
            result = result * 376439d;
        }
        else
        {
            result = result / 7d;
        }

        Console.WriteLine("{0:0.000}", result);

    }
}
