using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.ShoppingSample
{
    public class Bag : IItem
    {
        private string _name;
        private IList<IItem> _bags = new List<IItem>();

        public Bag(string name)
            => _name = name;
        

        public IItem this[int index]
            => _bags[index];

        public void Add(IItem item)
            => _bags.Add(item);

        public void Remove(IItem item)
            => _bags.Remove(item);

        public float CalcPrice()
            => _bags.Sum(item => item.CalcPrice());

        public void Show()
        {
            foreach(var item in _bags)
            {
                item.Show();
            }
        }
    }
}