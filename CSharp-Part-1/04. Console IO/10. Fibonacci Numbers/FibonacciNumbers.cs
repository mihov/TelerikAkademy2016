using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        ulong[] fibonacciArray = new ulong[n];
        fibonacciArray[0] = 0;
        if (n > 1)
        {
            fibonacciArray[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }
        }
        Console.WriteLine(String.Join(", ", fibonacciArray));
    }
}
