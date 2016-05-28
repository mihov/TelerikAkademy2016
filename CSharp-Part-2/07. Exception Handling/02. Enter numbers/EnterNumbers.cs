using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnterNumbers
{
    static int start = 1;
    static int end = 100;
    const int count = 10;

    static void Main()
    {
        List<int> numbers = new List<int>();

        for (int i = start; i <= count; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        try
        {
            if (numbers.Any(x => x < start) || numbers.Any(x => x > end) || !IsIncreasing(numbers))
            {
                throw new ArgumentException();
            }

            Console.WriteLine(start + " < " + string.Join(" < ", numbers) + " < " + end);
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }

    }

    private static bool IsIncreasing(List<int> numbers)
    {
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i - 1].CompareTo(numbers[i]) >= 0)
            {
                return false;
            }
        }

        return true;
    }
}
