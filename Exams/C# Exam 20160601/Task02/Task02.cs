using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static int NewPos(int maxPos, int currPos, int moves)
    {
        int result = 0;

        moves = moves % (maxPos + 1);

        result = currPos + moves;

        if (result > maxPos)
        {
            result = result % (maxPos + 1);
        }

        if (result < 0)
        {
            result = maxPos + 1 + result;

            if (result > maxPos)
            {
                result = result % (maxPos + 1);
            }

        }

        return result;
    }
    static void Main()
    {
        char[] theArray = Console.ReadLine().ToArray();
        int[] path = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int solulCount = 0;
        int foodCount = 0;
        int deadlock = 0;
        int jumps = 0;

        int currPos = 0;
        int maxPos = theArray.Length - 1;

        bool isDeadlocked = false;

        for (int i = 0; i < path.Length; i++)
        {


            switch (theArray[currPos])
            {
                case '@':
                    solulCount++;
                    theArray[currPos] = '0';
                    //currPos = NewPos(maxPos, currPos, path[i]);
                    break;
                case '*':
                    foodCount++;
                    theArray[currPos] = '0';
                    //currPos = NewPos(maxPos, currPos, path[i]);
                    break;
                case '0':
                    break;
                default:
                    deadlock++;
                    if (currPos % 2 == 0)
                    {
                        //@
                        if (solulCount > 0)
                        {
                            theArray[currPos] = '@';
                            solulCount--;

                        }
                        else {
                            isDeadlocked = true;
                            break;
                        }

                    }
                    else
                    {
                        //*
                        if (foodCount > 0)
                        {
                            theArray[currPos] = '*';
                            foodCount--;
                        }
                        else
                        {
                            isDeadlocked = true;
                            break;
                        }
                    }
                    break;
            }
            currPos = NewPos(maxPos, currPos, path[i]);
            
            if (isDeadlocked)
            {
                break;
            }
jumps++;

        }

        //Result
        if (isDeadlocked)
        {
            Console.WriteLine("You are deadlocked, you greedy kitty!");
            Console.WriteLine("Jumps before deadlock: {0}", jumps);
        }
        else
        {
            Console.WriteLine("Coder souls collected: {0}", solulCount);
            Console.WriteLine("Food collected: {0}", foodCount);
            Console.WriteLine("Deadlocks: {0}", deadlock);
        }
    }
}
