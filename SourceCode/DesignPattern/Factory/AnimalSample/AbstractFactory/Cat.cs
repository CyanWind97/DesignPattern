using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.AbstractFactory
{
    public abstract class Cat : Animal
    {
        public override void Eat()
            => Console.WriteLine("猫吃鱼");
    }

    public class MaleCat : Cat
    {
        public override void Gender()
            => Console.WriteLine("公猫");
    }


    public class FemaleCat : Cat
    {
        public override void Gender()
            => Console.WriteLine("母猫");
    }
}