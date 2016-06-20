using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());
        string[] allCode = new string[linesCount];

        for (int i = 0; i < linesCount; i++)
        {
            allCode[i] = Console.ReadLine();
        }


        string result = String.Empty;


        StringBuilder templines = new StringBuilder();


        //string tempStr;
        // comments

        int tempCounter = 0;
        for (int i = 0; i < linesCount; i++, tempCounter++)
        {
            allCode[i] = allCode[i].TrimStart(' ').TrimEnd(' ');

            if (allCode[i].Contains("//"))
            {
                allCode[i] = string.Empty;
            }

            if (allCode[i].Length > 0)
            {
                allCode[tempCounter] = allCode[i];

            }
            else
            {
                tempCounter--;
            }
        }

        string[] specialWords = { "bool", "int", "char", "string", "decimal" };

        linesCount = tempCounter;

        for (int i = linesCount - 1; i > 0; i--)
        {
            foreach (string item in specialWords)
            {
                if (allCode[i].IndexOf(item) == 0 && allCode[i - 1].IndexOf(item) == 0)
                {
                    allCode[i] = allCode[i].Replace(item+" ", ",");
                    allCode[i - 1] = allCode[i - 1].Replace(";", "");
                }
            }
        }



        for (int i = 0; i < linesCount; i++)
        {


            result = result + allCode[i];
        }
        result = result.Replace(" = ", "=").Replace(" (", "(").Replace("; ", ";").Replace(" < ", "<").Replace(" > ", ">");
 result = result.Replace(" =", "=").Replace(" ( ", "(").Replace(" ; ", ";").Replace(" <", "<").Replace(" >", ">");
 result = result.Replace("= ", "=").Replace("( ", "(").Replace(" ;", ";").Replace("< ", "<").Replace(" >", ">");
        result = result.Replace(", ", ",").Replace(" , ", ",").Replace(" ,", ",");


        int startIndex, endIndex;
        while (result.Contains("/*"))
        {
            startIndex = result.IndexOf("/*");
            endIndex = result.IndexOf("*/");

            result = result.Remove(startIndex, endIndex - startIndex + 2);
        }

        Console.WriteLine(result);




    }
}
