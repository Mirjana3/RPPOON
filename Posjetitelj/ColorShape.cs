using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public class ColorShape : ColorVisitor
    {
        public void ColorCircle(Circle circle)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void ColorSquare(Square square)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void ColorTriangle(Triangle triangle)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void ColorRectangle(Rectangle rectangle)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
    }
}
