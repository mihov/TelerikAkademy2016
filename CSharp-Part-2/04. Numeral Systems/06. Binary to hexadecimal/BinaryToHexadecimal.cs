﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_to_hexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine(BinaryToHex(Console.ReadLine()));
        }

        private static string BinaryToHex(string binNumber)
        {
            StringBuilder binaryNum = new StringBuilder(binNumber);

            bool isNegative = false;

            if (binaryNum[0] == '-')
            {
                isNegative = true;
                binaryNum.Remove(0, 1);
            }

            int length = binaryNum.Length;
            for (int i = 0; i < (4 - length % 4) % 4; i++)
            {
                binaryNum.Insert(0, '0');
            }

            StringBuilder hexNumber = new StringBuilder();

            StringBuilder word = new StringBuilder("0000");

            for (int fours = 0; fours < binaryNum.Length; fours += 4)
            {
                for (int pos = fours; pos < fours + 4; pos++)
                {
                    word[pos % 4] = binaryNum[pos];
                }

                switch (word.ToString())
                {
                    case "0000": hexNumber.Append('0'); break;
                    case "0001": hexNumber.Append('1'); break;
                    case "0010": hexNumber.Append('2'); break;
                    case "0011": hexNumber.Append('3'); break;
                    case "0100": hexNumber.Append('4'); break;
                    case "0101": hexNumber.Append('5'); break;
                    case "0110": hexNumber.Append('6'); break;
                    case "0111": hexNumber.Append('7'); break;
                    case "1000": hexNumber.Append('8'); break;
                    case "1001": hexNumber.Append('9'); break;
                    case "1010": hexNumber.Append('A'); break;
                    case "1011": hexNumber.Append('B'); break;
                    case "1100": hexNumber.Append('C'); break;
                    case "1101": hexNumber.Append('D'); break;
                    case "1110": hexNumber.Append('E'); break;
                    case "1111": hexNumber.Append('F'); break;
                }
            }

            if (isNegative)
            {
                hexNumber.Insert(0, '-');
            }

            return hexNumber.ToString();
        }
    }
}
