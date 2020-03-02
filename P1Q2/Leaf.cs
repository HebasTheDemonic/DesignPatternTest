using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q2
{
    class Leaf : Component
    {
        /// <summary>
        /// Constructor for a leaf object with null parent
        /// </summary>
        /// <param name="value"></param>
        public Leaf(int value) : base(value)
        {
        }

        /// <summary>
        /// Constructor for a leaf object with non-null parent
        /// </summary>
        /// <param name="value"></param>
        /// <param name="parent"></param>
        public Leaf(int value, Component parent) : base(value, parent)
        {
        }

        /// <summary>
        /// Leafs cannot have children therefore an exception is thrown
        /// </summary>
        /// <param name="component"></param>
        public override void Add(Component component)
        {
            throw new NotSupportedException("Leaf element cannot add child.");
        }

        /// <summary>
        /// Checks if the value of this leaf is odd or even.
        /// </summary>
        /// <returns bool>
        /// returns true of value is even.
        /// return false if value is odd.
        /// </returns>
        public override bool CheckEven()
        {
            if(value%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Leafs cannnot have children therefore an exception is thrown
        /// </summary>
        /// <param name="component"></param>
        public override void Remove(Component component)
        {
            throw new NotSupportedException("Leaf element cannot add child.");
        }

        /// <summary>
        /// calculates the sum of all values from calling object to the root.
        /// </summary>
        /// <returns></returns>
        public override int Sum()
        {
            int result = this.value;
            Component component = this;
            while (component.parent != null)
            {
                component = parent;
                result = result + component.value;
            }
            return result;
        }
    }
}
