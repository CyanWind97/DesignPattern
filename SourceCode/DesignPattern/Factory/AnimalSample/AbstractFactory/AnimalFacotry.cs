using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.AbstractFactory
{
    public abstract class AnimalFacotry
    {
        public abstract Animal CreateCat();

        public abstract Animal CreateDog();

    }


    public class MaleAnimalFacotry : AnimalFacotry
    {
        public override Animal CreateCat()
            => new MaleCat();

        public override Animal CreateDog()
            => new MaleDog();
    }

    public class FemaleAnimalFacotry : AnimalFacotry
    {
        public override Animal CreateCat()
            => new FemaleCat();

        public override Animal CreateDog()
            => new FemaleDog();
    }
}