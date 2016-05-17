using System;


class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine((SayNum(int.Parse(Console.ReadLine()) % 10)));
    }

    static string SayNum(int theNumber)
    {
        switch (theNumber)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "zero";
        }

    }
}
// zero one two three four five six seven eight nine