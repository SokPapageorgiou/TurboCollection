using System;
using System.Linq.Expressions;

namespace TurboCollections
{
    public class TList<T>
    {
        public TList() =>  Console.WriteLine("Hello Turbo!");   
        
        private T[] _items = Array.Empty<T>();

        public T[] Items => _items;

        public int Count => _items.Length;

        public void Add(T item)
        {
            Array.Resize(ref _items, Count + 1);
            
            _items[^1] = item;
        }

        public T Get(int index) => _items[index];

        public void Clear() => _items = Array.Empty<T>();
    }    
}

