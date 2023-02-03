using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.ComponentSample
{
    public interface IComponent
    {
        public void Add(IComponent c);

        public void Remove(IComponent c);

        public IComponent this[int index] { get; }

        public void Operation();
    }
}