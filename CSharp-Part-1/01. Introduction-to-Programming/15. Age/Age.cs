using System;

class Age
{
    static void Main()
    {
        string yearAsStr, readBDayAsStr = Console.ReadLine();

        yearAsStr = readBDayAsStr.Substring(readBDayAsStr.Length - 4);

        int birthYear = int.Parse(yearAsStr);
        int ageNow, ageAfter10Y;

        ageNow = DateTime.Now.Year - birthYear;
        ageAfter10Y = ageNow + 10;

        Console.WriteLine(ageNow);
        Console.WriteLine(ageAfter10Y);
    }
}