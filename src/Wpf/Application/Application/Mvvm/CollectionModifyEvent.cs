using System;
using System.Collections.Generic;

namespace Simprod.Application.Mvvm
{
    public class CollectionModifyEventArgs<T> : EventArgs
    {
        public IEnumerable<T> Items { get; }

        public CollectionModifyEventArgs(IEnumerable<T> items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            Items = items;
        }
    }

    public delegate void CollectionModifyEventHandler<T>(object sender, CollectionModifyEventArgs<T> e);
}