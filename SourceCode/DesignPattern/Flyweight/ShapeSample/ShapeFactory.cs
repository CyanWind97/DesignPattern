using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight.ShapeSample
{
    public static class ShapeFactory
    {
        private static Dictionary<string, IShape> _circleLookup = new ();

        public static IShape GetCircle(string color)
        {
            if(!_circleLookup.ContainsKey(color))
            {
                _circleLookup[color] = new Circle(color);
                Console.WriteLine($"Creating circle of color: {color}");
            }

            return _circleLookup[color];
        }
    }
}