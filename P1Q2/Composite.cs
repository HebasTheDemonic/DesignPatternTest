using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q2
{
    class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        /// <summary>
        /// Constructor for the main composite (parent will be null)
        /// </summary>
        /// <param name="value"></param>
        public Composite(int value) : base(value)
        {
        }

        /// <summary>
        /// Constructor for composites with a parent
        /// </summary>
        /// <param name="value"></param>
        /// <param name="parent"></param>
        public Composite(int value, Component parent) : base(value, parent)
        {
        }

        /// <summary>
        /// Adds a component to the children list
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Happens when the given component points to an incorrect or null parent component.
        /// </exception>
        /// <param name="component"></param>
        public override void Add(Component component)
        {
            if(component.parent == this)
            {
                _children.Add(component);
            }
            else
            {
                throw new InvalidOperationException("Child composites/leafs must point to correct parent composite.");
            }
        }

        /// <summary>
        /// Checks if the values of the composite and it's children are all even.
        /// </summary>
        /// <returns bool>
        /// return true if the values of this composite and all of its children are even numbers.
        /// return false if the value of this composite or any of its children is an odd number.
        /// </returns>
        public override bool CheckEven()
        {
            while (value%2 == 0)
            {
                foreach (Component child in _children)
                {
                    if (child.CheckEven())
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes a component from the child list.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Throws this exception if given component is not a child of this composite.
        /// </exception>
        /// <param name="component"></param>
        public override void Remove(Component component)
        {
            if (_children.Contains(component))
            {
                _children.Remove(component);
            }
            else
            {
                throw new InvalidOperationException("Composite does not contain this component");
            }
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
