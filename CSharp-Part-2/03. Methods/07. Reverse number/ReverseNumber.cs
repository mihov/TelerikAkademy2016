using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine(Reverse(Console.ReadLine()));
    }

    static string Reverse(string input)
    {
        string result = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            result = result.Trim() + input[i].ToString().Trim();
    }
        return result;
    }
}
