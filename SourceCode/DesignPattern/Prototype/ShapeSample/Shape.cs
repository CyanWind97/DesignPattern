using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.ShapeSample
{
    public abstract class Shape : ICloneable
    {
        public string ID { get; set; }

        public string Type { get; set; }

        public abstract void Draw();

        public object Clone()
        {
            try
            {
                var clone = base.MemberwiseClone();
                return clone;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle() : base()
            => Type = "Rectangle";

        public override void Draw()
            => Console.WriteLine("Inside Rectangle::draw() method.");
    }

    public class Square : Shape
    {
        public Square() : base()
            => Type = "Square";


        public override void Draw()
            => Console.WriteLine("Inside Square::draw() method.");  
    }

    public class Circle : Shape
    {
        public Circle() : base()
            => Type = "Circle";


        public override void Draw()
            => Console.WriteLine("Inside Circle::draw() method.");  
    }
}