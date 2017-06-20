using System.Collections.Generic;

using Simprod.Application.Controls;

namespace Simprod.Application.Mvvm
{
    public interface IViewModel<T>
    {
        event CollectionModifyEventHandler<T> ItemsAdd;
        event CollectionModifyEventHandler<T> ItemsRemove;

        void Add(T item);
        void AddRange(IEnumerable<T> item);
        void Remove(T item);
        void RemoveRange(IEnumerable<T> item);

        ModelControl<T> this[object id] { get; }
        ModelControl<T> this[T item] { get; }
    }
}