using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IntegerCalculations
{
    static void Main()
    {
        int[] intArray = SplitStrToInt(Console.ReadLine());
        //minimum, maximum, average, sum and product

        Console.WriteLine(CalcMin(intArray));
        Console.WriteLine(CalcMax(intArray));
        Console.WriteLine(CalcAverage(intArray).ToString("0.00"));
        Console.WriteLine(CalcSum(intArray));
        Console.WriteLine(CalcProduct(intArray));

    }

    static int[] SplitStrToInt(string text)
    {
        string[] tokens = text.Split(' ');
        return Array.ConvertAll<string, int>(tokens, int.Parse);
    }

    static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach (int element in elements)
            sum += element;
        return sum;
    }

    static long CalcMin(params int[] elements)
    {
        long min = long.MaxValue;
        foreach (int element in elements)
            if (min > element)
            {
                min = element;
            };
        return min;
    }

    static long CalcMax(params int[] elements)
    {
        long max = long.MinValue;
        foreach (int element in elements)
            if (max < element)
            {
                max = element;
            };
        return max;
    }
    static double CalcAverage(params int[] elements)
    {
        long sum = 0;
        int count = 0;
        foreach (int element in elements)
        {
            sum += element;
            count++;
        }

        return (double)sum / (double)count;
    }

    static double CalcProduct(params int[] elements)
    {
        long prod = 1;
        foreach (int element in elements)
        {
            prod *= element;
        }
        return prod;
    }

}

