using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternApp
{
    class ConsoleLogging
    {

        // This activates when the selected Car Class File runs, as it literally calls for it in it's statement. 
        public static void AutomobileBuildDialogue()
        {
            Console.WriteLine("Ordering From Ebay Motors");
            Thread.Sleep(1000);
            Console.WriteLine("Being Shipped..");
            Thread.Sleep(1000);
        }
    }
}
