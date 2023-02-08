using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.ComputerReadSample
{
    public interface IComputer
    {
        public string ReadSD(ISDCard sdCard);
    }


    public class Computer : IComputer
    {
        public string ReadSD(ISDCard sdCard)
            => sdCard.ReadSD();
    }
}