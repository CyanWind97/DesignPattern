using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Factory.AnimalSample.StaticFactory
{
    public static class AnimalFactory
    {
        public static Animal Create(string type)
        {
            if("dog" == type)
                return new Dog();
            else if("cat" == type)
                return new Cat();
            else
                return null;
        }
    }
}