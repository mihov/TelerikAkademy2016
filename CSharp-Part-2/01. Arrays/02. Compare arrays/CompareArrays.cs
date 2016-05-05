using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArrayA = new int[n], intArrayB = new int[n];
        bool isEqual = true;

        for (int i = 0; i < n; i++)
        {
            intArrayA[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            intArrayB[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (intArrayA[i] != intArrayB[i])
            {
                isEqual = false;
            }
        }

        Console.WriteLine((isEqual) ? "Equal" : "Not equal");
    }
}
