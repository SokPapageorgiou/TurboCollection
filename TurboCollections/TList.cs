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

        public void Set(int index, T value) => _items[index] = value;
        
        public void Clear() => _items = Array.Empty<T>();

        public void RemoveAt(int index)
        {
            for (int i = index; i < _items.Length - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item)) return true;
            }

            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item)) return i;
            }

            return -1;
        }
    }    
}

