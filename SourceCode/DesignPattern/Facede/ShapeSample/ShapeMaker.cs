using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facede.ShapeSample
{
    public class ShapeMaker
    {
        private IShape _circle;
        private IShape _rectangle;

        private IShape _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
            => _circle.Draw();
        

        public void DrawRectangle()
            => _rectangle.Draw();

        
        public void DrawSquare()
            => _square.Draw();
    }
}