using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public class Triangle : Shape
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public void accept(ShapeVisitor visitor)
        {
            visitor.visitTriangle(this);
        }

        public void accept(ColorVisitor visitor)
        {
            visitor.ColorTriangle(this);
        }

        public double getSide1()
        {
            return side1;
        }

        public double getSide2()
        {
            return side2;
        }

        public double getSide3()
        {
            return side3;
        }
    }
}
