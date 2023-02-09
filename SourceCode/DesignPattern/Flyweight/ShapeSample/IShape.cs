using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight.ShapeSample
{
    public interface IShape
    {
        public void Draw();
    }


    public class Circle : IShape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Radius { get; set;}

        public string Color { get; private set; }

        public Circle(string color)
            => Color = color;


        public void Draw()
            => Console.WriteLine($"Circle: Draw() [Color : {Color}, x : {X}, y :{Y}, radius :{Radius}");
    }
}