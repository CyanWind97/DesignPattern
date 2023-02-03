using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.FactoryMethod
{
    public abstract class AnimalFactory
    {
        public abstract Animal Create();
    }

    public class CatFacotry : AnimalFactory
    {
        public  override Animal Create()
            => new Cat();
    }

    public class DogFacotry : AnimalFactory
    {
        public override Animal Create()
            => new Dog();
    }
}