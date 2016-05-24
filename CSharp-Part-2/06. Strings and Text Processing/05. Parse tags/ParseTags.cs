using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseTags
{
    static void Main()
    {


        string startTag = "<upcase>";
        string endTag = "</upcase>";
        StringBuilder result = new StringBuilder();
        string[] inputString = Console.ReadLine().Split(new string[] { startTag, endTag }, StringSplitOptions.None);

        int currentElement = 1;
        foreach (var item in inputString)
        {
            if (currentElement % 2 == 0)
            {
                result.Append(item.ToUpper());
            }
            else
            {
                result.Append(item);
            }
            currentElement++;

        }

        Console.WriteLine(result.ToString());

    }
}