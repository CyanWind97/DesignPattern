using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.DrawShapeSample
{
    public abstract class Shape
    {
        protected IDrawAPI DrawAPI;

        public Shape(IDrawAPI drawAPI)
            => DrawAPI = drawAPI;
        
        public abstract void Draw();
    }


    public class Circle : Shape
    {
        private int _x;
        private int _y;

        private int _radius;

        public Circle(int x, int y, int radius, IDrawAPI drawAPI) : base(drawAPI)
            => (_x, _y, _radius) = (x, y, radius);

        public override void Draw()
            => DrawAPI.DrawCircle(_radius, _x, _y);
    }
}