using System;

class CompareCharArrays
{
    static void Main()
    {

        string intArrayA = Console.ReadLine();
        string intArrayB = Console.ReadLine();

        char theSign = '=';

        int minLength = Math.Min(intArrayA.Length, intArrayB.Length);

        if (intArrayA.Length == intArrayB.Length)
        {
            for (int i = 0; i < minLength; i++)
            {
                if (intArrayA[i] < intArrayB[i])
                {
                    theSign = '<';
                    break;
                }

                if (intArrayA[i] > intArrayB[i])
                {
                    theSign = '>';
                    break;
                }
            }
        }
        else
        {

            theSign = (intArrayA.Length > intArrayB.Length) ? '>' : '<';
        }

        Console.WriteLine(theSign);
    }
}