using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q6
{
    interface IShapeVisitor
    {
        float Visit(Square square);
        float Visit(Circle circle);
        float Visit(Triangle triangle);
    }
}
