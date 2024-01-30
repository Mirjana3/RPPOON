using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    public class Meal
    {
        public Beef beef;
        public Mushrooms mushrooms;
        public Noodles noodles;
        public Water water;
        public Meal()
        {
            beef = new Beef();
            mushrooms = new Mushrooms();
            noodles = new Noodles();
            water = new Water();
        }
        public void MakeMushroomNoodleSoup()
        {
            water.AddWater();
            mushrooms.AddMushrooms();
            noodles.AddNoddles();
        }

        public void MakeBeefNoodleSoup()
        {
            water.AddWater();
            beef.AddBeef();
            noodles.AddNoddles();
        }

        public void MakeMushroomBeefSoup()
        {
            water.AddWater();
            beef.AddBeef();
            mushrooms.AddMushrooms();
        }
    }
}
