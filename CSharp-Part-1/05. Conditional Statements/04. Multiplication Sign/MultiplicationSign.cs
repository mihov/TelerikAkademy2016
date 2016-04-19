using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int countsOfNegatives = 0;
        float currenNumber;
        bool hasZero = false;

        for (int i = 0; i < 3; i++)
        {
            currenNumber = float.Parse(Console.ReadLine());

            if (currenNumber == 0f)
            {
                hasZero = true;
            }

            if (currenNumber < 0)
            {
                countsOfNegatives++;
            }
        }

        if (hasZero)
        {
            Console.WriteLine(0);
        }
        else if (countsOfNegatives % 2 != 0)
        {
            Console.WriteLine('-');
        }
        else
        {
            Console.WriteLine('+');
        }
    }
}