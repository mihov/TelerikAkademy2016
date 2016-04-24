using System;

class NumbersFrom1toN
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}
