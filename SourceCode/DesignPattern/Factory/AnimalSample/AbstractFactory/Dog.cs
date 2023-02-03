using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.AbstractFactory
{
    public abstract class Dog : Animal
    {
        public override void Eat()
            => Console.WriteLine("狗吃肉");
    }

    public class MaleDog : Dog
    {
        public override void Gender()
            => Console.WriteLine("公狗");
    }

    public class FemaleDog : Dog
    {
        public override void Gender()
            => Console.WriteLine("母狗");
    }
}