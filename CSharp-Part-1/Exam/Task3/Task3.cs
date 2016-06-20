using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Task3
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());

        if (b < a)
        {
            int t = a;
            a = b;
            b = t;
        }

        int[] arrayOfInt = new int[b - a];

        int finalSum = 0;

        for (int i = a; i <= b; i++)
        {
            finalSum = finalSum + SumOfOddDEvitors(i);

        }
        //finalSum = SumOfOddDEvitors(a);

        Console.WriteLine(finalSum);
    }

    public static int SumOfOddDEvitors(int theNumber)
    {
        int result = 1;

        for (int i = 2; i <= theNumber; i++)
        {
            if (theNumber % i == 0)
            {
                if (i % 2 != 0)
                {
                    result = result + i;
                }
            }
        }
        return result;
    }
}
