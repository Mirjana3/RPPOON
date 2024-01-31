using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public interface IFruitBasket
    {
        void AddFruit(Fruit fruit, int quantity);
        FruitBasket GetFruitBasket();

    }
}
