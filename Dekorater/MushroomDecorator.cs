using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    public class MushroomDecorator : SoupDecorater
    {
        public MushroomDecorator(Meal meal) : base(meal) { }

        public override void PrepareSoup()
        {
            meal.water.AddWater();
            meal.mushrooms.AddMushrooms();
            meal.noodles.AddNoddles();
            Console.WriteLine("Add Mushroom");
        }
    }
}
