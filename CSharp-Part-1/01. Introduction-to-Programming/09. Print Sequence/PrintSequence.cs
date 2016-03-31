using System;

class PrintSequence
{
    static void Main()
    {
        bool sign = true;
        for (int counter = 1; counter < 11; counter++)
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