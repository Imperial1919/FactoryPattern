using System;
using System.Threading;

namespace FactoryPatternApp
{
    class Fourwheeler: ICallable
    {
        public void Build()
        {
            ConsoleLogging.PhoneBuildDialogue();
            Console.WriteLine("Building a luxury sedan!");
            Thread.Sleep(2000);
            Console.WriteLine(".... you better have the money for this..");
            Thread.Sleep(1000);
            Console.WriteLine("And there we have it, 80 grand please! ~");
        }
    }
}
