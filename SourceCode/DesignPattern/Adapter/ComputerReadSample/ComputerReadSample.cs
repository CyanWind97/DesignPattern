using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.ComputerReadSample
{
    public static class ComputerReadSample
    {
        public static void TestCase()
        {
            var computer = new Computer();
            ISDCard sdCard = new SDCard();
            Console.WriteLine(computer.ReadSD(sdCard));
            Console.WriteLine();

            ITFCard tfCard = new TFCard();
            var sdAdapterTF = new SDAdapterTF(tfCard);
            Console.WriteLine(computer.ReadSD(sdAdapterTF));
        }
    }
}