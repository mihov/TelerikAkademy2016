using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexOfLetters
{
    static void Main()
    {
        string theWord = Console.ReadLine();

        for (int i = 0; i < theWord.Length; i++)
        {
            Console.WriteLine(((int)theWord[i])-97);
        }

    }
}
