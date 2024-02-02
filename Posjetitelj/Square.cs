using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public void accept(ShapeVisitor visitor)
        {
            visitor.visitSquare(this);
        }

        public void accept(ColorVisitor visitor)
        {
            visitor.ColorSquare(this);
        }

        public double getSide()
        {
            return side;
        }
    }
}
