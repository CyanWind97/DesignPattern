using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.ShapeSample
{
    public interface IShape
    {
        public void Draw();
    }

    public class Rectangle : IShape
    {
        public void Draw()
            => Console.WriteLine("Shape: Rectangle");
    }


    public class Circle : IShape
    {
        public void Draw()
            => Console.WriteLine("Shape: Circle");
    }
}