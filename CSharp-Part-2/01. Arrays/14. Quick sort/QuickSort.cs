using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuickSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArrayA = new int[n];

        for (int i = 0; i < n; i++)
        {
            intArrayA[i] = int.Parse(Console.ReadLine());
        }

        QuickSort_Recursive(intArrayA, 0, n - 1);

        Console.WriteLine(String.Join("\n", intArrayA));
    }

    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;

            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSort_Recursive(int[] arr, int left, int right)
    {
        // For Recusrion
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
                QuickSort_Recursive(arr, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSort_Recursive(arr, pivot + 1, right);
        }
    }
}