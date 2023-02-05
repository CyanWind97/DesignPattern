using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.StockSample
{
    public class SellStock : IOrder
    {
        private Stock _stock;

        public SellStock(Stock stock)
            => _stock = stock;

        public void Execute()
            => _stock.Sell();
    }
}