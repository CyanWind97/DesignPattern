using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.StockSample
{
    public class Stock
    {
        private string _name = "ABC";
        private int _quantity = 10;

        public void Buy()
            => Console.WriteLine($"Stock [ Name: {_name}, Quantity: {_quantity} ] bought");

        public void Sell()
            => Console.WriteLine($"Stock [ Name: {_name}, Quantity: {_quantity} ] sold");
    }
}