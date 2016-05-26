using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractSentences
{
    static void Main()
    {

        //     string searcText = Console.ReadLine();
        //string[] allText = Console.ReadLine().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        //     //Console.WriteLine("\nWe found word {0} in:", searcText);


        //     for (int sentence = 0; sentence < allText.Length; sentence++)
        //     {
        //         if (allText[sentence].IndexOf(" " + searcText, 0) >= 0)
        //         {
        //             Console.WriteLine(allText[sentence] + '.');
        //         }
        //     }
        //--------------------
        string keyWord = Console.ReadLine().ToLower();
        string inputStringText = Console.ReadLine();
        inputStringText = inputStringText + " ";

        //inputStringText = inputStringText.Replace("... ", "... #$%&");
        inputStringText = inputStringText.Replace("! ", "! #$%&");
        inputStringText = inputStringText.Replace("? ", "? #$%&");
        inputStringText = inputStringText.Replace(". ", ". #$%&");


        string[] inputString = inputStringText.Split(new string[] { "#$%&" }, StringSplitOptions.None);


        string temp;
        foreach (var item in inputString)
        {
            temp = item.ToLower();
            if (temp.IndexOf(" " + keyWord+".") >= 0 || temp.IndexOf(" " + keyWord+" ") >= 0|| temp.IndexOf(" " + keyWord + ",") >= 0 || temp.IndexOf(" " + keyWord + "!") >= 0 || temp.IndexOf(" " + keyWord + "?") >= 0)
            {
                Console.Write(item);
            }


        }


    }
}
