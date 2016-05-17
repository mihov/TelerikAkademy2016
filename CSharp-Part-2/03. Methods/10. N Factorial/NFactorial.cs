using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        Console.WriteLine(Fac(BigInteger.Parse(Console.ReadLine())));
    }

    static BigInteger Fac(BigInteger n)
    {
        if (n <= 1)
            return 1;
        return n * Fac(n - 1);
    }
}
