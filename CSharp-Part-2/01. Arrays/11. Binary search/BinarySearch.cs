using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArrayA = new int[n];

        for (int i = 0; i < n; i++)
        {
            intArrayA[i] = int.Parse(Console.ReadLine());
        }

        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (intArrayA[i] == x)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i == n - 1)
            {
                Console.WriteLine("-1");
            }
        }
    }
}