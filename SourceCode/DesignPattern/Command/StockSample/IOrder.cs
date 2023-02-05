using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.StockSample
{
    public interface IOrder
    {
        public void Execute();
    }
}