using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.ComponentSample
{
    public static class ComponentSample
    {
        public static void TestCase()
        {
            IComponent c0 = new Composite();
            IComponent c1 = new Composite();
            IComponent leaf1 = new Leaf("1");
            IComponent leaf2 = new Leaf("2");
            IComponent leaf3 = new Leaf("3");

            c0.Add(leaf1);
            c0.Add(c1);
            c1.Add(leaf2);
            c1.Add(leaf3);

            c0.Operation();
        }
    }
}