using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.FactoryMethod
{
    public static class FactoryMethodSample
    {
        public static void TestCase()
        {
            AnimalFactory facotry;

            facotry = new CatFacotry();
            var a1 = facotry.Create();
            a1.Eat();

            facotry = new DogFacotry();
            var a2 = facotry.Create();
            a2.Eat();
        }
    }
}