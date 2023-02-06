using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.ShapeSample
{
    public static class ShapeSample
    {
        public static void TestCase()
        {
            var circle = new Circle();
            var redCircle = new RedSahpeDecorator(new Circle());
            var redRectangle = new RedSahpeDecorator(new Rectangle());

            Console.WriteLine("Circle with normal border");
            circle.Draw();
            Console.WriteLine();
        
            Console.WriteLine("Circle of red border");
            redCircle.Draw();
            Console.WriteLine();
        
            Console.WriteLine("Rectangle of red border");
            redRectangle.Draw();
            Console.WriteLine();
        }
    }
}