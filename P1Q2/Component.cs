using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q2
{
    abstract class Component
    {
        public int value;
        public Component parent;

        public Component(int value)
        {
            this.value = value;
        }

        public Component(int value, Component parent) : this(value)
        {
            this.parent = parent;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract bool CheckEven();
        public abstract int Sum();
    }
}
