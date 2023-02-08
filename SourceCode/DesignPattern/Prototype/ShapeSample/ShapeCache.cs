using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.ShapeSample
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> _shapeLookup = new ();

        public static Shape GetShape(string shapeId)
            => (Shape)_shapeLookup[shapeId].Clone();
        

        public static void LoadCache()
        {
            var circle = new Circle();
            circle.ID = "1";
            _shapeLookup[circle.ID] = circle;

            var square = new Square();
            square.ID = "2";
            _shapeLookup[square.ID] = square;

            var rectangle = new Rectangle();
            rectangle.ID = "3";
            _shapeLookup[rectangle.ID] = rectangle;
        }
    }
}