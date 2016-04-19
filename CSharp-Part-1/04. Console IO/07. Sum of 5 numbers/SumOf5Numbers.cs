using System;

class SumOf5Numbers
{
    static void Main()
    {
        int[] arrayOfInts = new int[5];
        for (int i = 0; i < 5; i++)
        {
            arrayOfInts[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum = sum + arrayOfInts[i];
        }

        Console.WriteLine(sum);
    }
}
