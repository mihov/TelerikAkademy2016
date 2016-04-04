using System;

class LongSequence
{
    static void Main()
    {
        for (int counter = 1; counter < 1001; counter++)
        {
            if ((counter % 2) == 0)
            {
                Console.WriteLine("-" + (counter + 1));
            }
            else
            {

                Console.WriteLine((counter + 1));
            }

        }
    }
}