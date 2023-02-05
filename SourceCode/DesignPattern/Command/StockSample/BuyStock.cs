using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.StockSample
{
    public class BuyStock : IOrder
    {
        private Stock _stock;

        public BuyStock(Stock stock)
            => _stock = stock;

        public void Execute()
            => _stock.Buy();
    }
}