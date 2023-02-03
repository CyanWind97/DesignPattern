using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.ShoppingSample
{
    public class Goods : IItem
    {
        private string _name;

        private int _quantity;

        private float _price;


        public Goods(string name, int quantity, float price)
            => (_name, _quantity, _price) = (name, quantity, price);

        public float CalcPrice()
            => _quantity * _price;

        public void Show()
            => Console.WriteLine($"{_name}（数量：{_quantity}，单价：{_price}元）");
    }
}