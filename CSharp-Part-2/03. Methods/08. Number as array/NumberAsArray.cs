using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class NumberAsArray
{
    const byte first = 0;
    const byte second = 1;
    const byte transfer = 2;
    const byte result = 3;

    static void Main()
    {


        int[] digitLenghts = SplitStrToInt(Console.ReadLine());
        int maxElements = GetMax(digitLenghts[first], digitLenghts[second]);

        int digit0Len = digitLenghts[first];
        int digit1Len = digitLenghts[second];

        int subLen = digit0Len - digit1Len;

        string digit0Str = Console.ReadLine();
        string digit1Str = Console.ReadLine();

        if (subLen > 0)
        {
            digit1Str = AddZeroes(digit1Str, subLen);
        }
        else if (subLen < 0)
        {
            digit0Str = AddZeroes(digit0Str, (subLen));
        }

        string[] digit0 = digit0Str.Split(' ');
        string[] digit1 = digit1Str.Split(' ');

        //Console.WriteLine(String.Join(" ", digit0));
        // Console.WriteLine(String.Join(" ", digit1));

        int[,] matrixToCalc = new int[4, maxElements + 1];

        matrixToCalc = FillTheMatrix(digit0, digit1, maxElements);

        int[] resultArray = calcTheMatrix(matrixToCalc, maxElements);

        //Console.WriteLine(String.Join(" ", resultArray));

        PrintMatrix(resultArray, maxElements);

    }

    private static void PrintMatrix(int[] resultArray, int maxElements)
    {
        for (int i = 0; i < maxElements; i++)
        {
            Console.Write(resultArray[i]);
            if (i < maxElements)
            {
                Console.Write(" ");
            }
        }
        if (resultArray[maxElements] > 0)
        {
            Console.WriteLine(" " + resultArray[maxElements]);
        }
        else
        {
            Console.WriteLine();
        }
    }

    private static int[] calcTheMatrix(int[,] matrixToCalc, int maxElements)
    {
        int[] resultArr = new int[maxElements + 1];

        for (int i = 0; i < maxElements; i++)
        {
            matrixToCalc[result, i] = matrixToCalc[first, i] + matrixToCalc[second, i] + matrixToCalc[transfer, i];
            if (matrixToCalc[result, i] > 9)
            {
                matrixToCalc[result, i] -= 10;
                matrixToCalc[transfer, i + 1]++;
            }

            resultArr[i] = matrixToCalc[result, i];
        }

        resultArr[maxElements] = matrixToCalc[transfer, maxElements];

        return resultArr;
    }

    private static int[,] FillTheMatrix(string[] digit0, string[] digit1, int maxElements)
    {
        int[,] matrix = new int[4, maxElements + 1];

        for (int i = 0; i < maxElements; i++)
        {
            matrix[first, i] = int.Parse(digit0[i]);
            matrix[second, i] = int.Parse(digit1[i]);
            matrix[result, i] = 0;
            matrix[transfer, i] = 0;
        }
        matrix[result, maxElements] = 0;
        matrix[transfer, maxElements] = 0;

        return matrix;
    }

    //static Byte[] SplitStrToInt(string text)
    //{
    //    string[] tokens = text.Split(' ');
    //    return Array.ConvertAll<string, byte>(tokens, byte.Parse);
    //}
    static int[] SplitStrToInt(string text)
    {
        string[] tokens = text.Split(' ');
        return Array.ConvertAll<string, int>(tokens, int.Parse);
    }


    static string Reverse(string input)
    {
        string result = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            result = result.Trim() + input[i].ToString().Trim();
        }
        return result;
    }

    static string AddSpaces(string input)
    {
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            result = (result + input[i].ToString().Trim() + " ");
        }
        return result;
    }

    static int GetMax(int first, int second)
    {
        return first >= second ? first : second;
    }

    static string AddZeroes(string input, int ZeroeCaunt)
    {
        for (int i = 0; i < Math.Abs(ZeroeCaunt); i++)
        {
            input = (input + " 0");
        }

        return input;
    }
}
