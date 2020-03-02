using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q6
{
    class ResolutionChangerVisitor : IShapeVisitor
    {
        public float Visit(Square square)
        {
            /*
             * This is how you remove eye glasses.
             */
            return 1;
        }

        public float Visit(Circle circle)
        {
            /*
            * This is how you remove eye glasses.
            */
            return 1;
        }

        public float Visit(Triangle triangle)
        {
            /*
            *  This is how you remove eye glasses.
            */
            return 1;
        }
    }
}
