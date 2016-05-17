using System;

class GetLargestNumber
{
    static void Main()
    {
        int[] intArray = SplitStrToInt(Console.ReadLine());

        Console.WriteLine(GetMax(GetMax(intArray[0], intArray[1]), intArray[2]));
    }

    static int[] SplitStrToInt(string text)
    {
        string[] tokens = text.Split(' ');
        return Array.ConvertAll<string, int>(tokens, int.Parse);
    }

    static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum >= secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }
}