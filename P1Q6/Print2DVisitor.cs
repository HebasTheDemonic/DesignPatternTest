using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q6
{
    class Print2DVisitor : IShapeVisitor
    {
        public float Visit(Square square)
        {
            /*
             * Instructions on how to break a printer go here.
             */
            return 1;
        }

        public float Visit(Circle circle)
        {
            /*
             * Instructions on how to break a printer go here.
             */
            return 1;
        }

        public float Visit(Triangle triangle)
        {
            /*
             * Instructions on how to break a printer go here.
             */
            return 1;
        }
    }
}
