using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.DrawShapeSample
{
    public interface IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y);
    }


    public class RedCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
            => Console.WriteLine($"Drawing Circle[ color: red, radius: {radius}, ({x}, {y})]");
    }

    public class GreenCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
            => Console.WriteLine($"Drawing Circle[ color: green, radius: {radius}, ({x}, {y})]");
    }
}