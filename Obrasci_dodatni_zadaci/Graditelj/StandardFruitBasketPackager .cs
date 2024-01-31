using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class StandardFruitBasketPackager : IFruitBasket
    {
        private FruitBasket basket = new FruitBasket();
        public void AddFruit(Fruit fruit, int quantity)
        {
            if (!basket.Contents.ContainsKey(fruit))
            {
                basket.Contents[fruit] = quantity;
            }
            else
            {
                basket.Contents[fruit] += quantity;
            }
        }
        public FruitBasket GetFruitBasket()
        {
            return basket;
        }

    }
}
