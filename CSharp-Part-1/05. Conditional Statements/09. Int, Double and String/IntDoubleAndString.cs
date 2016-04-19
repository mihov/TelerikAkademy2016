using System;
using System.Globalization;
using System.Threading;

class IntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string typeOf = Console.ReadLine();
        string valueOf = Console.ReadLine();
        switch (typeOf)
        {
            case "integer": { Console.WriteLine(int.Parse(valueOf) + 1); } break;
            case "real": { Console.WriteLine((double.Parse(valueOf) + 1).ToString("N", CultureInfo.InvariantCulture)); } break;
            case "text": { Console.WriteLine("{0}*", valueOf); } break;
            default:
                break;
        }
    }
}

//  integer for int
//  real for double
//  text for string