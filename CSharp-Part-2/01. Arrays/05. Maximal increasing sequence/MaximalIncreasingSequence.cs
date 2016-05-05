using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArrayA = new int[n];

        int maxSeq = 1, tempMaxSeq = 1;

        for (int i = 0; i < n; i++)
        {
            intArrayA[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < n; i++)
        {
            if (intArrayA[i] > intArrayA[i - 1])
            {
                tempMaxSeq++;
            }
            else
            {
                tempMaxSeq = 1;
            }

            maxSeq = Math.Max(tempMaxSeq, maxSeq);

        }
        Console.WriteLine(maxSeq);



    }
}
