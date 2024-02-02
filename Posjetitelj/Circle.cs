using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void accept(ShapeVisitor visitor)
        {
            visitor.visitCircle(this);
        }

        public void accept(ColorVisitor visitor)
        {
            visitor.ColorCircle(this);
        }

        public double getRadius()
        {
            return radius;
        }
    }
}
