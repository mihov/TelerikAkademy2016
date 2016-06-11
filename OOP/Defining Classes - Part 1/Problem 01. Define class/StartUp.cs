using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class StartUp
    {
        static void Main(string[] args)
        {

            GSMTest letTest = new GSMTest();
            letTest.DisplayGsmInformation();

            GSMCallHistoryTest callTest = new GSMCallHistoryTest();

            callTest.Functionality();
        }
    }










}
