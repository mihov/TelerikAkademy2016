using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArrayA = new int[n];

        for (int i = 0; i < n; i++)
        {
            intArrayA[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < n - 1; j++)
        {
            int iMin = j;

            for (int i = j + 1; i < n; i++)
            {
                if (intArrayA[i] < intArrayA[iMin])
                {
                    iMin = i;
                }
            }

            if (iMin != j)
            {
                Swap(intArrayA, j, iMin);
            }
        }

        Console.WriteLine(String.Join("\n", intArrayA));
    }

    static int Swap(int[] theArray, int a, int b)
    {
        int temp = theArray[a];
        theArray[a] = theArray[b];
        theArray[b] = temp;

        return 0;
    }
}
