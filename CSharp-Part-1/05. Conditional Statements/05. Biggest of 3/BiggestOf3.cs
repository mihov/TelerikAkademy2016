using System;
using System.Linq;

class BiggestOf3
{
    static void Main()
    {
        float[] arrayOfFloat = new float[3];
        for (int i = 0; i < 3; i++)
        {
            arrayOfFloat[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine(arrayOfFloat.Max()); 
    }
}