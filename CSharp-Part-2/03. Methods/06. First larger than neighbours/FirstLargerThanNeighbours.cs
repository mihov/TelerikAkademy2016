using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        bool reached = false;

        int[] theIntArray = SplitStrToInt(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            if (LargerOne(theIntArray, i, size))
            {
                Console.WriteLine(i);
                reached = true;
                break;
            }
        }
        if (!reached)
        {
            Console.WriteLine(-1);
        }

    }

    static bool LargerOne(int[] inputArray, int position, int lenght)
    {
        if (position > 0 && position < lenght - 1)
        {
            return inputArray[position - 1] < inputArray[position] && inputArray[position] > inputArray[position + 1];
        }
        return false;
    }

    static int[] SplitStrToInt(string text)
    {
        string[] tokens = text.Split(' ');
        return Array.ConvertAll<string, int>(tokens, int.Parse);
    }
}
