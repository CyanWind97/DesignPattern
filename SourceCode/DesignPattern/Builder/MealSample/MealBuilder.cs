using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder.MealSample
{
    public class MealBuilder
    {
        private List<Item> _items = new ();

        public MealBuilder PrepareVegMeal()
        {
            _items.Add(new VegBurger());
            _items.Add(new Coke());

            return this;
        }

        public MealBuilder PrepareNonVegMeal()
        {
            _items.Add(new ChichkenBurger());
            _items.Add(new Pepsi());

            return this;
        }


        public MealBuilder AddItem(Item item)
        {
            _items.Add(item);
            return this;
        }


        public Meal Build()
        {
            var meal = new Meal();
            foreach(var item in _items)
            {
                meal.AddItem(item);
            }

            return meal;
        }
    }
}