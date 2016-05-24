using System;


class SubStringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine().ToLowerInvariant();
        string inputString = Console.ReadLine().ToLowerInvariant();

        int counter = 0;
        int index = 0;
        do
        {
            index = inputString.IndexOf(pattern, index);
            if (index >= 0)
            {
                index++;
                counter++;
            }

        } while (index > 0);

        Console.WriteLine(counter);
    }
}
