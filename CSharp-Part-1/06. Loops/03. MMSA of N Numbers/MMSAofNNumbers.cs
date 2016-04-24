using System;
using System.Linq;


class MMSAofNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] arrayOfInt = new double[n];
        for (int i = 0; i < n; i++)
        {
            arrayOfInt[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("min={0:f2}", arrayOfInt.Min());
        Console.WriteLine("max={0:f2}", arrayOfInt.Max());
        Console.WriteLine("sum={0:f2}", arrayOfInt.Sum());
        Console.WriteLine("avg={0:f2}", arrayOfInt.Average());
    }
}
