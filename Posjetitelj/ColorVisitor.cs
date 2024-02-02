using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public interface ColorVisitor
    {
        void ColorCircle(Circle circle);
        void ColorSquare(Square square);
        void ColorTriangle(Triangle triangle);
        void ColorRectangle(Rectangle rectangle);

    }
}
