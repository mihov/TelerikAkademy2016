using System;
using System.Linq;

class OneSystemToAnyOther
{
    static void Main()
    {
        long baseX = long.Parse(Console.ReadLine());
        string number = Console.ReadLine();

        long baseY = long.Parse(Console.ReadLine());

        Console.WriteLine(ConvertFromDecimalToBaseY(ConvertToDecimal(number.ToArray(), baseX), baseY));
    }

    static long ConvertToDecimal(char[] number, long baseX)
    {
        long result = 0;
        for (long i = (long)number.Length - 1, pow = 1; i >= 0; i--, pow *= baseX)
            result += (number[i] >= 'A') ? (number[i] - 'A' + 10) * pow : (number[i] - '0') * pow;
        return result;
    }

    static string ConvertFromDecimalToBaseY(long number, long baseY)
    {
        string result = string.Empty;
        while (number > 0)
        {
            long remainder = number % baseY;
            result = remainder >= 10 ? (char)('A' + remainder - 10) + result : remainder + result;
            number /= baseY;
        }
        return result;
    }
}
