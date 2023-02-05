using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.StockSample
{
    public class Broker
    {
        private List<IOrder> _orders = new List<IOrder>();

        public void TakeOrder(IOrder order)
            => _orders.Add(order);

        
        public void PlaceOrders()
        {
            foreach(var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear();
        }
    }
}