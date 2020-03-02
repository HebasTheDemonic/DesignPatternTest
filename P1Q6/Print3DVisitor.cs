using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q6
{
    class Print3DVisitor : IShapeVisitor
    {
        public float Visit(Square square)
        {
            /*
             * G-code generator for square goes here.
             */
            return 1;
        }

        public float Visit(Circle circle)
        {
            /*
             * G-code generator for circle goes here.
             */
            return 1;
        }

        public float Visit(Triangle triangle)
        {
            /*
             * G-code generator for triangle goes here.
             */
            return 1;
        }
    }
}
