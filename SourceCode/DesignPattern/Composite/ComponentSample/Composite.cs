using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.ComponentSample
{
    public class Composite : IComponent
    {
        private List<IComponent> _children = new ();

        
        public IComponent this[int index]
            => _children[index];

        public void Add(IComponent c)
            => _children.Add(c);

        public void Remove(IComponent c)
            => _children.Remove(c);


        public void Operation()
        {
            foreach(var c in _children)
            {
                c.Operation();
            }
        }

        
    }
}