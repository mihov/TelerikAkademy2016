using System;
using System.Globalization;
using System.Threading;

class Age
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        DateTime birthDay = DateTime.Parse(string.Format("{0:MM.dd.yyyy}", Console.ReadLine()));
        int ageNow = DateTime.Now.Year - birthDay.Year;
        if (DateTime.Now.Month < birthDay.Month)
            ageNow--;
        else if (DateTime.Now.Month == birthDay.Month)
        {
            if (DateTime.Now.Day < birthDay.Day)
                ageNow--;
        }
        Console.WriteLine(ageNow);
        Console.WriteLine(ageNow + 10);
    }
}