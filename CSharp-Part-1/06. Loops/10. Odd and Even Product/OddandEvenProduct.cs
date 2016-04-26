using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddandEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int[] arrayOfInts = new int[n];

        string arrayAsStr = Console.ReadLine();
        string[] tokens = arrayAsStr.Split(' ');

        int[] arrayOfInts = Array.ConvertAll<string, int>(tokens, int.Parse);

        int oddSum = 1, evenSum = 1;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                evenSum = evenSum * arrayOfInts[i];
               
            }
            else
            {
                oddSum = oddSum * arrayOfInts[i];
               
            }
        }


        if (evenSum == oddSum)
        {
            Console.WriteLine("yes {0}", oddSum);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenSum, oddSum);
        }

    }
}
