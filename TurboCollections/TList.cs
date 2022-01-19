using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public class TList<T>
    {
        public TList() =>  Console.WriteLine("Hello Turbo!");   
        
        private T[] _items = Array.Empty<T>();

        public T[] Items => _items;

        public int Count { get; set; }


        public void Add(T item)
        {
            Count++;
            Array.Resize(ref _items, Count);
            
            _items[^1] = item;
        }

        public T Get(int index) => _items[index];

        public void Set(int index, T value) => _items[index] = value;

        public void Clear()
        {
            _items = Array.Empty<T>();
            Count -= Count;
        } 

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[Count - 1] = default;
            Count--;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(item)) return i;
            }

            return -1;
        }

        public void Remove(T value)
        {
            var index = IndexOf(value);
            if (index == -1) return;
            RemoveAt(index); 
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var var in collection)
            {
                Add(var);
            }
        }
    }    
}

