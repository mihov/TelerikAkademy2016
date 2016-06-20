using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class StartUp
{



    static void Main()


    {
      


        BigInteger base26 = Conv26To10(Console.ReadLine());
        char sign = Console.ReadLine()[0];
        BigInteger base7 = Conv7To10New(Console.ReadLine());
        BigInteger result = 0;

        //Console.WriteLine(base26);

        //Console.WriteLine(base7);


        switch (sign)
        {
            case '+':
                result = base26 + base7;
                //Console.WriteLine(base26+"+"+base7+"="+result);
                break;   
            default:
                result = base26 - base7;
                //Console.WriteLine(base26 + "-" + base7 + "=" + result);
                break;
        }


        Console.WriteLine(DecimalToBase(result));
    }

    static BigInteger Conv26To10(string input)
    {
        BigInteger result = 0;
        foreach (char digit in input)
        {
            result = (BigInteger)(digit - 'a') + result * 26;
        }
        return result;
    }


    static BigInteger Conv7To10New(string input)
    {
        BigInteger result = 0;
        foreach (char digit in input)
        {
            result = (BigInteger)(digit - '0') + result * 7;
        }
        return result;
    }

    

    static BigInteger Pow(BigInteger a, ulong b) {
        BigInteger result = 1;
        for (BigInteger i = 0; i < a; i++)
        {
            result *= b;
        }
        return result;
    }

    static string DecimalToBase(BigInteger dec)
    {
        string octStr = string.Empty;

        while (dec > 0)
        {
            octStr =(dec % 9) + octStr;
            dec /= 9;
        }
             

        return octStr;


    }



}
