using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine((Math.Abs(a - b) < eps).ToString().ToLower());
    }
}