using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceInMatrix
{
    static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(' ');

        int[] matrixDimention = Array.ConvertAll<string, int>(inputLine, int.Parse);

        int row = matrixDimention[0];
        int col = matrixDimention[1];

        string[,] theMatrix = new string[row, col];

        int maxCount = 0, tempMaxCount = 0;

        for (int i = 0; i < row; i++)
        {
            inputLine = Console.ReadLine().Split(' ');

            for (int j = 0; j < col; j++)
            {
                theMatrix[i, j] = inputLine[j];
            }
        }

        //PrintMatrix(theMatrix);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                tempMaxCount = 1 + SumUp(theMatrix, i, j) + SumDown(theMatrix, i, j) +
                SumUpLeft(theMatrix, i, j) + SumDownLeft(theMatrix, i, j) +
                SumUpRight(theMatrix, i, j) + SumDownRight(theMatrix, i, j) +
                SumRight(theMatrix, i, j) + SumLeft(theMatrix, i, j);

                if (tempMaxCount > maxCount)
                {
                    maxCount = tempMaxCount;
                }
                tempMaxCount = 0;
            }
        }
        Console.WriteLine(maxCount);



    }

    static int SumUp(string[,] matrix, int row, int col)
    {
        int result = 0;
        string candidate = matrix[row, col];

        for (int i = row - 1; i >= 0; i--)
        {
            if (matrix[i, col] == candidate)
            {
                result++;
            }
        }
        return result;
    }

    static int SumDown(string[,] matrix, int row, int col)
    {
        int result = 0;
        string candidate = matrix[row, col];
        int maxRow = matrix.GetLength(0);
        //int maxCol = matrix.GetLength(1);

        for (int i = row + 1; i < maxRow; i++)
        {
            if (matrix[i, col] == candidate)
            {
                result++;
            }
        }
        return result;
    }

    static int SumLeft(string[,] matrix, int row, int col)
    {
        int result = 0;
        string candidate = matrix[row, col];
        //int maxRow = matrix.GetLength(0);
        //int maxCol = matrix.GetLength(1);

        for (int i = col - 1; i >= 0; i--)
        {
            if (matrix[row, i] == candidate)
            {
                result++;
            }
        }
        return result;
    }

    static int SumRight(string[,] matrix, int row, int col)
    {
        int result = 0;
        string candidate = matrix[row, col];
        //int maxRow = matrix.GetLength(0);
        int maxCol = matrix.GetLength(1);

        for (int i = col + 1; i < maxCol; i++)
        {
            if (matrix[row, i] == candidate)
            {
                result++;
            }
        }
        return result;
    }

    static int SumUpLeft(string[,] matrix, int row, int col)
    {
        int result = 0;
        string candidate = matrix[row, col];
        //int maxRow = matrix.GetLength(0);
        //int maxCol = matrix.GetLength(1);

        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (matrix[i, j] == candidate)
            {
                result++;
            }
        }
        return result;
    }

    static int SumUpRight(string[,] matrix, int row, int col)
    {
        int result = 0;
        string candidate = matrix[row, col];
        //int maxRow = matrix.GetLength(0);
        int maxCol = matrix.GetLength(1);

        for (int i = row - 1, j = col + 1; i >= 0 && j <  maxCol; i--, j++)
        {
            if (matrix[i, j] == candidate)
            {
                result++;
            }
        }
        return result;
    }
    static int SumDownLeft(string[,] matrix, int row, int col)
    {
        int result = 0;
        string candidate = matrix[row, col];
        int maxRow = matrix.GetLength(0);
        int maxCol = matrix.GetLength(1);

        for (int i = row + 1, j = col - 1; i < maxRow && j >=0; i++, j--)
        {
            if (matrix[i, j] == candidate)
            {
                result++;
            }
        }
        return result;
    }

    static int SumDownRight(string[,] matrix, int row, int col)
    {
        int result = 0;
        string candidate = matrix[row, col];
        int maxRow = matrix.GetLength(0);
        int maxCol = matrix.GetLength(1);

        for (int i = row + 1, j = col + 1; i < maxRow && j < maxCol; i++, j++)
        {
            if (matrix[i, j] == candidate)
            {
                result++;
            }
        }
        return result;
    }
    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}{1}", matrix[i, j], (j + 1 < matrix.GetLength(1)) ? " " : "\n");
            }

        }
    }
}