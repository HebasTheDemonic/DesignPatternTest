using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q6
{
    abstract class Shape : IShapeVisitable
    {
        public abstract float Accept(IShapeVisitor visitor);
    }
}
