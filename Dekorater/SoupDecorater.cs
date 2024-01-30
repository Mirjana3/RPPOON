using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    public abstract class SoupDecorater
    {
        protected Meal meal;
        public SoupDecorater(Meal meal)
        {
            this.meal = meal;
        }

        public abstract void PrepareSoup();
    }
}
