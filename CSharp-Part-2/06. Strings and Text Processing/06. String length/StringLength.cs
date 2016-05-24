using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        //Console.WriteLine(inputString.Length);
        inputString = inputString.Replace(@"\", string.Empty);

        if (inputString.Length < 20)
        {
            inputString = inputString.Trim() + new string('*', 20 - inputString.Length);
        }

        Console.WriteLine(inputString);

    }
}
