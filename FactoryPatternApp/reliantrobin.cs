using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternApp
{
    class ReliantRobin : ICallable
    {
        public void Build()
        {
            ConsoleLogging.PhoneBuildDialogue(); //Activating the PhoneBuildDialouge static method by adding the class it is directly a part of first, with a dot operator.
            Console.WriteLine("Building an.. Meme mobile- RELIANT ROBIN.");
            Thread.Sleep(2000);
            Console.WriteLine("You sure bout' this, I mean, this vehicle is less stable than the stock market..... ooook then.");
            Thread.Sleep(2000);
            Console.WriteLine("And there we have it!");
        }
    }
}
