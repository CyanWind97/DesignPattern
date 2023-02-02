using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class SingletonPattern : IDesignPattern
    {
        public void TestCase()
        {
            var intstance1 = Singleton1.Instance;
            var intstance2 = Singleton2.Instance;
            var intstance3 = Singleton3.Instance;
            var intstance4 = Singleton4.Instance;
            var intstance = Singleton.Instance;
        }
    }
}