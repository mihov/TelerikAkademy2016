using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(' ');

        int[] matrixDimention = Array.ConvertAll<string, int>(inputLine, int.Parse);

        int row = matrixDimention[0];
        int col = matrixDimention[1];

        int[,] theMatrix = new int[row, col];
        int[] tempRow = new int[col];

        int maxSum = int.MinValue, tempMaxSum = 0;

        for (int i = 0; i < row; i++)
        {
            inputLine = Console.ReadLine().Split(' ');
            tempRow = Array.ConvertAll<string, int>(inputLine, int.Parse);

            for (int j = 0; j < col; j++)
            {
                theMatrix[i, j] = tempRow[j];
            }
        }

        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= col; j++)
            {
                if (IsInside_3x3(theMatrix, i, j))
                {
                    tempMaxSum = CalcMatrix_3x3(theMatrix, i, j);
                }


                if (tempMaxSum > maxSum)
                {
                    maxSum = tempMaxSum;
                }

                tempMaxSum = 0;
            }
        }

        Console.WriteLine(maxSum);
    }

    static int CalcMatrix_3x3(int[,] inputMatrix, int coordR, int coorC)
    {
        int resultSum = 0;

        for (int i = coordR; i < coordR + 3; i++)
        {
            for (int j = coorC; j < coorC + 3; j++)
            {
                resultSum += inputMatrix[i, j];
            }
        }

        return resultSum;
    }

    static bool IsInside_3x3(int[,] inputMatrix, int coordR, int coordC)
    {
        int rowsMax = inputMatrix.GetLength(0) - 1;
        int colsMax = inputMatrix.GetLength(1) - 1;

        return (coordR + 2 <= rowsMax) && (coordC + 2 <= colsMax);
    }
}
