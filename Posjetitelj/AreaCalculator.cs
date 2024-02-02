using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public class AreaCalculator : ShapeVisitor
    {
        public void visitCircle(Circle circle)
        {
            double area = Math.PI * circle.getRadius() * circle.getRadius();
            Console.WriteLine("Area of circle: " + area);
        }

        public void visitSquare(Square square)
        {
            double area = square.getSide() * square.getSide();
            Console.WriteLine("Area of square: " + area);
        }

        public void visitTriangle(Triangle triangle)
        {
            // Using Heron's formula to calculate the area of a triangle
            double s = (triangle.getSide1() + triangle.getSide2() + triangle.getSide3()) / 2;
            double area = Math.Sqrt(s * (s - triangle.getSide1()) * (s - triangle.getSide2()) * (s - triangle.getSide3()));
            Console.WriteLine("Area of triangle: " + area);
        }

        public void visitRectangle(Rectangle rectangle)
        {
            double area = rectangle.getLength() * rectangle.getWidth();
            Console.WriteLine($"Area of rectangle: {area}");
        }
    }
}
