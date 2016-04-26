using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimaltoBinary
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string binary = string.Empty;

        while (number > 0)
        {
            binary += number % 2;
            number = number / 2;
        }

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            Console.Write(binary[i]);
        }
    }
}
