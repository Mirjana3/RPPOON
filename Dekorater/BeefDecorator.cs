using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    public class BeefDecorator : SoupDecorater
    {
        public BeefDecorator(Meal meal) : base(meal) { }

        public override void PrepareSoup()
        {
            meal.water.AddWater();
            meal.beef.AddBeef();
            meal.noodles.AddNoddles();
            Console.WriteLine("Add Beef");
        }
    }
}
