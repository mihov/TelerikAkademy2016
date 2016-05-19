using System;

class Program
{
    static void Main()
    {
        if (isLeap(int.Parse(Console.ReadLine())))
        {
            Console.WriteLine("Leap");
        }
        else {
            Console.WriteLine("Common");
        }
    }

    public static bool isLeap(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            return true;
        }
        else {
            return false;
        }

    }
}