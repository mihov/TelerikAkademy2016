using System;
using System.Linq;

class BiggestOf5
{
    static void Main()
    {
        float[] arrayOfFloat = new float[5];
        for (int i = 0; i < 5; i++)
        {
            arrayOfFloat[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine(arrayOfFloat.Max());
    }
}
