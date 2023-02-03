using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.AbstractFactory
{
    public static class AbstractFactorySample
    {
        public static void TestCase()
        {
            AnimalFacotry facotry;

            facotry = new FemaleAnimalFacotry();
            facotry.CreateCat().Gender();
            facotry.CreateDog().Gender();

            facotry = new MaleAnimalFacotry();
            facotry.CreateCat().Gender();
            facotry.CreateDog().Gender();
        }
    }
}