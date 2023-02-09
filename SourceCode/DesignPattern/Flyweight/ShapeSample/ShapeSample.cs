using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight.ShapeSample
{
    public static class ShapeSample
    {
        public static void TestCase()
        {
            var colors = new string[]{"Red", "Green", "Blue", "White", "Black"};
            
            var random = new Random();
            
            for(int i = 0; i < 20; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(colors[random.Next(colors.Length)]);
                circle.X = random.Next(100);
                circle.Y = random.Next(100);
                circle.Radius = 100;
                circle.Draw();
            }
        }
    }
}