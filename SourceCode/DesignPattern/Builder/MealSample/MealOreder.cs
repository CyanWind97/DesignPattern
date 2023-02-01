using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder.MealSample
{
    public static class MealOreder
    {
        public static void TestCase()
        {
            var vegMeal = (new MealBuilder())
                            .PrepareVegMeal()
                            .Build();
            Console.WriteLine("蔬菜套装");
            vegMeal.ShowItems();
            Console.WriteLine($"总价：{vegMeal.GetCost()}");

            Console.WriteLine();
            Console.WriteLine();

            var nonVegMeal = (new MealBuilder())
                            .PrepareNonVegMeal()
                            .Build();
            Console.WriteLine("纯肉套装");
            nonVegMeal.ShowItems();
            Console.WriteLine($"总价：{nonVegMeal.GetCost()}");

            Console.WriteLine();
            Console.WriteLine();

            var customVegMeal = (new MealBuilder())
                            .AddItem(new ChichkenBurger())
                            .AddItem(new Coke())
                            .Build();
            Console.WriteLine("自定义套装");
            customVegMeal.ShowItems();
            Console.WriteLine($"总价：{customVegMeal.GetCost()}");
        }
    }
}