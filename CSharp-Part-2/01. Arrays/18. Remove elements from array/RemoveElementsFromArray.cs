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
        int minNumber = int.MinValue;
        int tempNumberUp, tempNumberDown;

        for (int i = 0; i < n; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
            intSubArrayLong[i] = 1;
        }

        for (int i = 0; i < n - 1; i++)
        {
            tempNumberUp = intArray[i];
            tempNumberDown = intArray[i];


            for (int j = i + 1; j < n; j++)
            {

                if (tempNumberUp <= intArray[j])
                {
                    tempNumberUp = intArray[j];
                    intSubArrayLong[i]++;
                    //Console.Write("{0} ", intArray[j]);
                }

            }

            for (int j = i - 1; j >= 0; j--)
            {
                if (tempNumberDown >= intArray[j])
                {
                    tempNumberDown = intArray[j];
                    intSubArrayLong[i]++;
                    //Console.Write("{0} ", intArray[j]);
                }
            }


           
        }

        for (int i = 0; i < n; i++)
        {
            //Console.Write("{0} ", intSubArrayLong[i]);
            if (intSubArrayLong[i] > minNumber)
            {
                minNumber = intSubArrayLong[i];
            }
        }


        //Console.WriteLine();
        Console.WriteLine(n - minNumber);
    }
}
