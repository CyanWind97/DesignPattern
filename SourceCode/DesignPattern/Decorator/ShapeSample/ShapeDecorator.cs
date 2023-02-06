using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.ShapeSample
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape DecoratedShape;

        public ShapeDecorator(IShape decoratedShape)
            => DecoratedShape = decoratedShape;

        public virtual void Draw()
            => DecoratedShape.Draw();
    }


    public class RedSahpeDecorator : ShapeDecorator
    {
        public RedSahpeDecorator(IShape decoratedShape) 
            : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            DecoratedShape.Draw();
            SetBorder(DecoratedShape);
        }


        private void SetBorder(IShape decoratedShape)
            => Console.WriteLine("Border Color: Red");
    }
}