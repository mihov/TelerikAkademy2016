using System;
using System.Globalization;
using System.Threading;

class SumOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine(a + b + c);
    }
}
