using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0) continue;
            if (i % 7 == 0) continue;
            Console.Write("{0} ", i);
        }
    }
}
