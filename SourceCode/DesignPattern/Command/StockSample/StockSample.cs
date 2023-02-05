using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.StockSample
{
    public static class StockSample
    {
        public static void TestCase()
        {
            var stock = new Stock();

            var buyOrder = new BuyStock(stock);
            var sellOrder = new SellStock(stock);

            var broker = new Broker();
            broker.TakeOrder(buyOrder);
            broker.TakeOrder(sellOrder);

            broker.PlaceOrders();
        }
    }
}