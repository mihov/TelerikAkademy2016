using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortingArray
{
    static void Main()
    {
        Console.ReadLine();
        int[] arrayOfInts = SplitStrToInt(Console.ReadLine());

        QuickSort(arrayOfInts, 0, arrayOfInts.GetLength(0) - 1);

        Console.WriteLine(String.Join(" ", arrayOfInts));
    }

    static int[] SplitStrToInt(string text)
    {
        string[] tokens = text.Split(' ');
        return Array.ConvertAll<string, int>(tokens, int.Parse);
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

    static public void QuickSort(int[] arr, int left, int right)
    {
        // For Recusrion
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
                QuickSort(arr, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSort(arr, pivot + 1, right);
        }
    }
}
