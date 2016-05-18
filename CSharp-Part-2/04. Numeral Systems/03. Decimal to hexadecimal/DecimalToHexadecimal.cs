using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimal
{
    static void Main()
    {

        long decimalNumber = long.Parse(Console.ReadLine());
        string hexaNumber = "";                             // other way: string hexaNumber = null;         
        while (decimalNumber > 0)
        {
            long checkRemainder = (long)decimalNumber % 16; // must be long; when this type is int the result is wrong
            string remainder = "";
            switch (checkRemainder)
            {
                case 10: remainder = "A"; break;
                case 11: remainder = "B"; break;
                case 12: remainder = "C"; break;
                case 13: remainder = "D"; break;
                case 14: remainder = "E"; break;
                case 15: remainder = "F"; break;
                default: remainder = checkRemainder.ToString(); break;
            }
            hexaNumber = remainder + hexaNumber;
            decimalNumber /= 16;
        }
        Console.WriteLine(hexaNumber);
    }

    static string DecToHexBit(int bit)
    {

        switch (bit)
        {
            case 10: return "A";
            case 11: return "B";
            case 12: return "C";
            case 13: return "D";
            case 14: return "E";
            case 15: return "F";
            default: return bit.ToString();
        };
    }
}
