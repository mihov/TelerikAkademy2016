using System;
using System.Text;


class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine(HexToBin(Console.ReadLine()));
    }

    private static string HexToBin(string hexNumber)
    {
        StringBuilder binNumber = new StringBuilder();

        foreach (char hexDigit in hexNumber)
        {
            switch (hexDigit)
            {
                case '0': binNumber.Append("0000"); break;
                case '1': binNumber.Append("0001"); break;
                case '2': binNumber.Append("0010"); break;
                case '3': binNumber.Append("0011"); break;
                case '4': binNumber.Append("0100"); break;
                case '5': binNumber.Append("0101"); break;
                case '6': binNumber.Append("0110"); break;
                case '7': binNumber.Append("0111"); break;
                case '8': binNumber.Append("1000"); break;
                case '9': binNumber.Append("1001"); break;
                case 'A': binNumber.Append("1010"); break;
                case 'B': binNumber.Append("1011"); break;
                case 'C': binNumber.Append("1100"); break;
                case 'D': binNumber.Append("1101"); break;
                case 'E': binNumber.Append("1110"); break;
                case 'F': binNumber.Append("1111"); break;
            }
        }


        int zeroesAtFront = 0;

        for (int index = 0; index < binNumber.Length; index++)
        {
            if (binNumber[index] != '0')
            {
                break;
            }

            zeroesAtFront++;
        }


        binNumber.Remove(0, zeroesAtFront);

        return binNumber.ToString();
    }

}