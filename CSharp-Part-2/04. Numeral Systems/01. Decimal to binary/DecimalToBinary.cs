using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinary
{
    static void Main()
    {
        BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine());

        BigInteger remainder;
        string result = string.Empty;

        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine(result);
    }
}
