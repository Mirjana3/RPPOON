using System;
using System.Collections.Generic;
using System.Text;

public enum Fruit { Apple, Banana, Orange }

namespace Obrasci_dodatni_zadaci
{
    public class ClientCode
    {
        public static void Run()
        {
            IFruitBasket builder = new StandardFruitBasketPackager();

            FruitBasketPreSets director = new FruitBasketPreSets(builder);

            director.MakeBasketForCustomer1();
            FruitBasket basket1 = builder.GetFruitBasket();
            Console.WriteLine("Basket for Customer 1:");

            foreach(var basket in basket1.Contents)
            {
                Console.WriteLine($"{basket.Key}: {basket.Value}");
            }

            director.MakeBasketForCustomer2();
            FruitBasket basket2 = builder.GetFruitBasket();
            Console.WriteLine("\nBasket for Customer 2:");
            foreach (var basket in basket2.Contents)
            {
                Console.WriteLine($"{basket.Key}: {basket.Value}");
            }
        }
    }
}
