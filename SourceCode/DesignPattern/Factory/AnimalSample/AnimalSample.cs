using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample
{
    public static class AnimalSample
    {
        public static void TestCase()
        {
            StaticFactory.StaticFactorySample.TestCase();
            FactoryMethod.FactoryMethodSample.TestCase();
            AbstractFactory.AbstractFactorySample.TestCase();
        }
    }
}