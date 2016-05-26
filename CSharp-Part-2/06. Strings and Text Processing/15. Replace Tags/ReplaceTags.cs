using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Input	Output
<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. 
Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	

<p>Please visit [our site](http://academy.telerik.com) to choose a training course. 
Also visit [our forum](www.devbg.org) to discuss the courses.</p>
*/



class ReplaceTags
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        StringBuilder theText = new StringBuilder();

        string startA = "<a href=\""; 
        string endA = "\">"; 
        string closeA = "</a>"; 

        string url;
        string title;
        string toInsert;
        string leftPart;
        string rightPart;

        int startAPosition = 0;
        int endAPosition = 0;
        int closeAPosition = 0;

        while (true)
        {
            startAPosition = inputText.IndexOf(startA, startAPosition);
            if (startAPosition < 0) break;
            endAPosition = inputText.IndexOf(endA, startAPosition);
            closeAPosition = inputText.IndexOf(closeA, endAPosition);

            url = inputText.Substring(startAPosition + startA.Length, endAPosition - startAPosition - startA.Length);

            title = inputText.Substring(endAPosition + endA.Length, closeAPosition - endAPosition + endA.Length - closeA.Length);

            leftPart = inputText.Substring(0, startAPosition);
            rightPart = inputText.Substring(closeAPosition + closeA.Length);

            url = "(" + url + ")";
            title = "[" + title + "]";

            toInsert = title + url;

            inputText = leftPart + toInsert + rightPart;

            //Console.WriteLine(url);
            //Console.WriteLine(title);
            //Console.WriteLine(inputText);


        }

        Console.WriteLine(inputText);
    }


}
