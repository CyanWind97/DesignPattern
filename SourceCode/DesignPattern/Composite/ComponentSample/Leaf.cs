using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.ComponentSample
{
    public class Leaf : IComponent
    {

        private string _name;

        public IComponent this[int index]
            => null;

        public Leaf(string name)
        {
            _name = name;
        }

        public void Add(IComponent c)
        {
           
        }

        public void Remove(IComponent c)
        {
            
        }

        

        public void Operation()
            => Console.WriteLine($"树叶{_name}：被访问");

        
    }
}