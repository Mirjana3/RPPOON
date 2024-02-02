using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public interface Shape
    {
        void accept(ShapeVisitor visitor);
        void accept(ColorVisitor visitor);
    }
}
