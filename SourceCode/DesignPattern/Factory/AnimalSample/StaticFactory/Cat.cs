using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.StaticFactory
{
    public class Cat : Animal
    {
        public override void Eat()
            => Console.WriteLine("猫吃鱼");
    }
}