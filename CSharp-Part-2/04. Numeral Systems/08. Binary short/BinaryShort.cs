using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryShort
{
    static void Main()
    {
        Console.WriteLine(ShortToBinary(short.Parse(Console.ReadLine())));
    }

    static string ShortToBinary(short number)
    {
        string binaryNumber = string.Empty;

        for (int i = 15; i >= 0; i--)
        {
            binaryNumber = ((number % 2) & 1) + binaryNumber;
            number >>= 1;
        }
        return binaryNumber;
    }
}
