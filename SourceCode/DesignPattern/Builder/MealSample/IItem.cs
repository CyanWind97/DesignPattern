using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder.MealSample
{
    public abstract class Item
    {
        public abstract string Name { get; }
        public abstract Packing Packing { get; }

        public abstract float Price { get; }
    }

    
}