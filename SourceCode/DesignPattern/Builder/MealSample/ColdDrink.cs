using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder.MealSample
{
    public abstract class ColdDrink : Item
    {
        public override Packing Packing
            => new Bottle();

    }


    public class Coke : ColdDrink
    {
        public override string Name
            => "可口可乐";

        public override float Price
            => 30.0f;
    }

    public class Pepsi : ColdDrink
    {
        public override string Name
            => "百事可乐";

        public override float Price
            => 35.0f;
    }
}