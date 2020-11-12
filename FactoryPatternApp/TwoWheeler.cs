using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternApp
{
    class TwoWheeler : ICallable
    {
        public void Build()
        {
            ConsoleLogging.PhoneBuildDialogue();
            Console.WriteLine("Are you Insane or just imbecillic?.... I mean.. alright...");
            Thread.Sleep(2000);
            Console.WriteLine("and there We have it, a.. two wheel 'car'... More a overly complex motorbike, gonna be honest.");
        }
    }
}
