using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder.MealSample
{
    public class Meal
    {
        private List<Item> _items = new List<Item>();

        public void AddItem(Item item)
            => _items.Add(item);
        

        public float GetCost()
            => _items.Sum(item => item.Price);
        

        public void ShowItems()
        {
            foreach(var item in _items)
            {
                Console.WriteLine($"食物：{item.Name}，包装：{item.Packing.Pack}，价格：{item.Price}");
            }
        }
    }
}