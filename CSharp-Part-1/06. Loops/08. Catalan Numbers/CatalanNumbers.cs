using System;
using System.Numerics;


class CatalanNumbers
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine((Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n)));
    }

    public static BigInteger Factorial(int n)
    {
        BigInteger factorial = 1;

        for (int i = n; i > 0; i--)
        {
            factorial *= i;
        }

        return factorial;
    }
}
