using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q6
{
    class Square : Shape
    {
        public override float Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
