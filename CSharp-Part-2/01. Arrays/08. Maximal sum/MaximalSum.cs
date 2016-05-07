using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArrayA = new int[n];

        int currentSum = 0, maxSum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            intArrayA[i] = int.Parse(Console.ReadLine());

            currentSum += intArrayA[i];

            if (currentSum < intArrayA[i])
            {
                currentSum = intArrayA[i];
            }


            if (maxSum < currentSum)
            {
                maxSum = currentSum;
            }
        }

        Console.WriteLine(maxSum);
    }
}
