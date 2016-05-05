using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        List<int> intList = new List<int>();

        for (int i = 0; i < n; i++)
        {
            intList.Add(int.Parse(Console.ReadLine()));
        }

        int maxElement;
        int maxSum = 0;

        for (int i = 0; i < k; i++)
        {
            maxElement = intList.Max();
            intList[ intList.IndexOf(maxElement)] = int.MinValue;
            maxSum += maxElement;
        }

        Console.WriteLine(maxSum);


    }
}
