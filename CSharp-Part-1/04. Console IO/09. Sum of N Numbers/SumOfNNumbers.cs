using System;
using System.Globalization;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int numberOfElements = int.Parse(Console.ReadLine());
        float[] arrayOfInts = new float[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            arrayOfInts[i] = float.Parse(Console.ReadLine());
        }

        float sum = 0f;
        for (int i = 0; i < numberOfElements; i++)
        {
            sum = sum + arrayOfInts[i];
        }

        Console.WriteLine(sum);
    }
}
