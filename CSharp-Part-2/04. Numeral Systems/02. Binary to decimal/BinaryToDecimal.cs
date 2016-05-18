using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimal
{
    static void Main()
    {
        string inputBin = Console.ReadLine();
        int len = inputBin.Length;

        BigInteger result = 0;
        BigInteger position;

        for (int i = 0; i < len; i++)
        {
            position = (BigInteger)Math.Pow(2, len - i - 1);
            result += int.Parse(inputBin[i].ToString()) * position;
        }

        Console.WriteLine(result);



    }
}
