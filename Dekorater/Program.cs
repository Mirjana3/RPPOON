using System;

namespace Dekorater
{
    class Program
    {
        static void Main(string[] args)
        {
            SoupDecorater mushroomSoup = new MushroomDecorator(new Meal());
            Console.WriteLine("Mushroom Soup:");
            mushroomSoup.PrepareSoup();

            Console.WriteLine();
        }
    }
}
