using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseURL
{
    static void Main()
    {
        string inputStr = Console.ReadLine();

        int collPosition = inputStr.IndexOf(':');

        string protokol = inputStr.Substring(0, collPosition);
        Console.WriteLine("[protocol] = {0}", protokol);

        int endAddrPos = inputStr.IndexOf('/', collPosition + 3);
        string address = inputStr.Substring(collPosition + 3, endAddrPos - collPosition-3);
        Console.WriteLine("[server] = {0}", address);

        string resource = inputStr.Substring(endAddrPos);
        Console.WriteLine("[resource] = {0}", resource);
    }

}
