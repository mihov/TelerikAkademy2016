using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractSentences
{
    static void Main()
    {
        string keyWord = Console.ReadLine().ToLower();
        string inputStringText = Console.ReadLine().Replace("...", "...#$%&");
        inputStringText = inputStringText.Replace("!", "!#$%&");
        inputStringText = inputStringText.Replace("?", "?#$%&");
inputStringText = inputStringText.Replace(".", ".#$%&");


        string[] inputString = inputStringText.Split(new string[] { "#$%&" }, StringSplitOptions.None);


        string temp;
        foreach (var item in inputString)
        {
            temp = item.ToLower().Trim();
            if (temp.IndexOf(keyWord) >= 0)
            {
                Console.Write(item);
            }


        }


    }
}
