using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class FruitBasketPreSets
    {
        private IFruitBasket basket;
        public FruitBasketPreSets(IFruitBasket basket)
        {
            this.basket = basket;
        }
        public void MakeBasketForCustomer1()
        {
            basket.AddFruit(Fruit.Apple, 5);
            basket.AddFruit(Fruit.Banana, 3);
            basket.AddFruit(Fruit.Orange, 2);

        }
        public void MakeBasketForCustomer2()
        {
            basket.AddFruit(Fruit.Banana, 10);
            basket.AddFruit(Fruit.Orange, 5);
        }

    }
}