using System;

class AppearanceCount
{
    static void Main()
    {
        Console.ReadLine();
        Console.WriteLine(AppCount(Console.ReadLine(), Console.ReadLine()));
    }

    static int AppCount(string inputText, string pattern)
    {
        string[] strArray = inputText.Split(' ');
        int counter = 0;
        for (int i = 0; i < strArray.Length; i++)
        {
            if (pattern == strArray[i])
            {
                counter++;
            }
        }
        return counter;
    }
}
