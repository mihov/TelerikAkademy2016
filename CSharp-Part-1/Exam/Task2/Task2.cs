using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task2
{
    static void Main()
    {
        int numberOfCars = int.Parse(Console.ReadLine());

        int[] arrayOfSpeeds = new int[numberOfCars];

        for (int i = 0; i < numberOfCars; i++)
        {
            arrayOfSpeeds[i] = int.Parse(Console.ReadLine());
        }

        // Console.WriteLine(String.Join(" ",arrayOfSpeeds));

        int groupCarsCoun = 1, tempGroupCarsCoun = 1;
        int groupCarsSpeedSum = arrayOfSpeeds[0], tempGroupCarsSpeedSum = arrayOfSpeeds[0];
        int currentMinSpeed = arrayOfSpeeds[0];

        for (int i = 1; i < numberOfCars; i++)
        {
            if (arrayOfSpeeds[i] <= arrayOfSpeeds[i - 1])
            {
                currentMinSpeed = arrayOfSpeeds[i];
                tempGroupCarsCoun = 1;
                tempGroupCarsSpeedSum = arrayOfSpeeds[i];
            }

            if (arrayOfSpeeds[i] > arrayOfSpeeds[i - 1])
            {
                tempGroupCarsCoun++;
                tempGroupCarsSpeedSum = tempGroupCarsSpeedSum + arrayOfSpeeds[i];
                arrayOfSpeeds[i] = currentMinSpeed;
            }

            if (groupCarsCoun < tempGroupCarsCoun)
            {

                groupCarsSpeedSum = tempGroupCarsSpeedSum;
                groupCarsCoun = tempGroupCarsCoun;

            }

            if (groupCarsCoun == tempGroupCarsCoun)
            {
                if (groupCarsSpeedSum < tempGroupCarsSpeedSum)
                {
                    groupCarsSpeedSum = tempGroupCarsSpeedSum;
                }

            }
        }
        Console.WriteLine(groupCarsSpeedSum);

    }
}