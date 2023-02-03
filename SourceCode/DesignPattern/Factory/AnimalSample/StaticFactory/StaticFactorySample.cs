using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.StaticFactory
{
    public static class StaticFactorySample
    {
        public static void TestCase()
        {
           var a1 = AnimalFactory.Create("cat");
           a1.Eat();

           var a2 = AnimalFactory.Create("dog");
           a2.Eat();
        }
    }
}