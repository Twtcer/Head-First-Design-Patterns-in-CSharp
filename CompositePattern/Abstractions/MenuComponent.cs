using System;
using System.Collections.Generic;
using CompositePattern.Iterators;

namespace CompositePattern.Abstractions
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string Name => throw new NotSupportedException();
        public virtual string Description => throw new NotSupportedException();
        public virtual double Price => throw new NotSupportedException();
        public virtual bool IsVegetarian => throw new NotSupportedException();

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new NullEnumerator();
        }
    }
}
