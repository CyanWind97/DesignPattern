using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.ShapeSample
{
    public static class ShapeSample
    {
        public static void TestCase()
        {
            ShapeCache.LoadCache();

            Shape clonedShape1 = (Shape) ShapeCache.GetShape("1");
            Console.WriteLine($"Shape : {clonedShape1.Type}");        
        
            Shape clonedShape2 = (Shape) ShapeCache.GetShape("2");
            Console.WriteLine($"Shape : {clonedShape2.Type}");        
        
            Shape clonedShape3 = (Shape) ShapeCache.GetShape("3");
             Console.WriteLine($"Shape : {clonedShape3.Type}");  
        }
    }
}