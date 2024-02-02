using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public void accept(ShapeVisitor visitor)
        {
            visitor.visitRectangle(this);
        }

        public void accept(ColorVisitor visitor)
        {
            visitor.ColorRectangle(this);
        }

        public double getLength()
        {
            return length;
        }

        public double getWidth()
        {
            return width;
        }
    }
}
