using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.ComputerReadSample
{
    public class SDAdapterTF : ISDCard
    {
        private ITFCard _tfCard;

        public SDAdapterTF(ITFCard tfCard)
            => _tfCard = tfCard;

        public string ReadSD()
        { 
            Console.WriteLine("adapter read tf card");
            return _tfCard.ReadTF();
        }
            

        public void WriteSD(string message)
        {
            Console.WriteLine("adapter write tf card");
            _tfCard.WriteTF(message);
        }
    }
}