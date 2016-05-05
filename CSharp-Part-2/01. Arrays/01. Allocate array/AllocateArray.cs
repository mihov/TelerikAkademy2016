using System;

class AllocateArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            intArray[i] = i * 5;
        }

        Console.WriteLine(String.Join("\n", intArray));
    }
}