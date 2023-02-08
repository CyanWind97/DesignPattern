using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.DrawShapeSample
{
    public static class DrawShapeSample
    {
        public static void TestCase()
        {
            var redCircle = new Circle(100, 100, 10, new RedCircle());
            var greenCicle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCicle.Draw();
        }
    }
}