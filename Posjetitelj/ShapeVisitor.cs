using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public interface ShapeVisitor
    {
        void visitCircle(Circle circle);
        void visitSquare(Square square);
        void visitTriangle(Triangle triangle);
        void visitRectangle(Rectangle rectangle);
    }
}
