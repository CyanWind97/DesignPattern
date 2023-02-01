using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder.MealSample
{
    // 汉堡
    public abstract class Burger : Item
    {
        public override Packing Packing
            => new Wrapper();

    }

    public class VegBurger : Burger
    {
        public override string Name
            => "蔬菜汉堡";

        public override float Price
            => 25.0f;
    }

    public class ChichkenBurger : Burger
    {
        public override string Name
            => "鸡肉汉堡";

        public override float Price
            => 50.5f;
    }
}