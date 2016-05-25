using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SeriesOfLetters
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        char currentChar = inputString[inputString.Length - 1];
        int deleteCounter = 0;
        //int startDelIndex = 1;
        for (int i = inputString.Length - 2; i >= 0; i--)
        {
            if (currentChar == inputString[i])
            {
                deleteCounter++;
            }
            else if (deleteCounter > 0)
            {
                inputString = inputString.Remove(i + 1, deleteCounter);
                //startDelIndex = i;
                deleteCounter = 0;
                currentChar = inputString[i];
            }
            else
            {
                //startDelIndex = i;
                deleteCounter = 0;
                currentChar = inputString[i];
            }


        }
        if (deleteCounter > 0)
        {
            inputString = inputString.Remove(0, deleteCounter);
        }
            
            Console.WriteLine(inputString);
    }
}