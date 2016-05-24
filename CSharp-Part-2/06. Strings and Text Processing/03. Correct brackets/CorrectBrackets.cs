using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        int firstL = inputString.IndexOf('(');
        int firstR = inputString.IndexOf(')');
        int LastL = inputString.LastIndexOf('(');
        int lastR = inputString.LastIndexOf(')');

        if (firstL < firstR && LastL < lastR)
        {
            int countL = 0;
            int countR = 0;
            foreach (char c in inputString)
            {
                if (c == '(') countL++;
                if (c == ')') countR++;
            }

            if (countL == countR)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }


        }
        else {
            Console.WriteLine("Incorrect");
        }

    }


}
