using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumIntegers
{
    static void Main()
    {
        string inputStr = Console.ReadLine();

        Console.WriteLine(SumIntArray(StrToArray(inputStr)));
    }


    static int[] StrToArray(string inputString)
    {
        return inputString.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
    }
    static int SumIntArray(int[] theArray)
    {
        return theArray.Sum();
    }


}
