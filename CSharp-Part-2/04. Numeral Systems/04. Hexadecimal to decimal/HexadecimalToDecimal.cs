using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hexadecimal_to_decimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HexToDecimal(Console.ReadLine()));
        }
        private static long HexToDecimal(string hexNumber)
        {
            long decimalNumber = 0;

            for (int position = 0; position < hexNumber.Length; position++)
            {
                int multiplier;

                switch (hexNumber[hexNumber.Length - position - 1])
                {
                    case 'A': multiplier = 10; break;
                    case 'B': multiplier = 11; break;
                    case 'C': multiplier = 12; break;
                    case 'D': multiplier = 13; break;
                    case 'E': multiplier = 14; break;
                    case 'F': multiplier = 15; break;
                    default: multiplier = int.Parse(hexNumber[hexNumber.Length - position - 1].ToString()); break;
    
                }

                decimalNumber += multiplier * (long)Math.Pow(16, position);
            }

            return decimalNumber;
        }
    }


}
