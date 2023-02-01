using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder.MealSample
{
    // 包装方式
    public abstract class Packing
    {
        public abstract string Pack { get;}
    }

    public class Bottle : Packing
    {
        public override string Pack
            => "瓶子";
    }

    public class Wrapper : Packing
    {
        public override string Pack
            => "纸盒";
    }
}