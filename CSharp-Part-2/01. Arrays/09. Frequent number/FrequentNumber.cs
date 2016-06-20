using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArrayA = new int[n];

        Dictionary<int, int> resultArray = new Dictionary<int, int>();

        int currentKey;

        for (int i = 0; i < n; i++)
        {
            currentKey = int.Parse(Console.ReadLine());

            if (resultArray.ContainsKey(currentKey))
            {
                resultArray[currentKey]++;
            }
            else
            {
                resultArray.Add(currentKey, 1);
            }
        }

        Console.WriteLine("{0} ({1} times)", resultArray.FirstOrDefault(x => x.Value == resultArray.Values.Max()).Key, resultArray.Values.Max());
    }
}
