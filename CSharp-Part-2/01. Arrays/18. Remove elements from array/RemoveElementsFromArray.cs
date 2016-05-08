using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];
        int[] intSubArrayLong = new int[n];

        for (int i = 0; i < n; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
            intSubArrayLong[i] = 1;
        }

        int max = 1;
        for (int i = 1; i < n; i++)
        {
            for (int k = 0; k < i; k++)
            {
                if (intArray[i] >= intArray[k] && intSubArrayLong[i] <= intSubArrayLong[k] + 1)
                {
                    intSubArrayLong[i] = intSubArrayLong[k] + 1;

                    if (max < intSubArrayLong[i])
                    {
                        max = intSubArrayLong[i];
                    }
                }
            }
        }

        Console.WriteLine(n - max);
    }
}
