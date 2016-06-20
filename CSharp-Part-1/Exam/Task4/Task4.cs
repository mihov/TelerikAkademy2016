using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task4
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        char theChar = Console.ReadLine()[0];

        int mag6 = 6;
        if (rows > 18)
        {
            mag6 = 7;
        }

        //int magW = rows/2 -(int)((rows - 10) / 4);

        string emptySp = new string(' ', (int)rows / mag6);
        //ear
        Console.WriteLine(" {0}{1}{0}", theChar.ToString(), emptySp);

        //head
        for (int i = 0; i < (int)rows / mag6; i++)
        {

            Console.WriteLine(" {0}", new string(theChar, (int)rows / mag6 + 2));
        }

        // neck
        for (int i = 0; i < (int)rows / mag6; i++)
        {

            Console.WriteLine("  {0}", new string(theChar, (int)rows / mag6));
        }

        //upBody
        for (int i = 0; i <= (int)rows / mag6; i++)
        {

            Console.Write(" {0}", new string(theChar, (int)rows / mag6 + 2));
            if (i == ((int)rows / mag6))
            {
                Console.Write("   {0}", new string(theChar, ((int)rows / 4)));
            }
            Console.WriteLine();
        }

        //DownBody
        for (int i = 0; i < ((int)rows-1) / (mag6/2); i++)
        {
            Console.WriteLine("{0}  {1}", new string(theChar, ((int)rows / 4) + 3), theChar.ToString());
        }
        Console.WriteLine("{0} {1}{1}", new string(theChar, ((int)rows / 4) + 3), theChar.ToString());

        Console.WriteLine(" {0}", new string(theChar, ((int)rows / 4) + 4));
    }
}