using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace TurboCollections
{
    public class TList<T> : IEnumerable<T>
    {
        public TList() => Console.WriteLine("Hello Turbo!");

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

        public Enumerator GetEnumerator()
        {
            return new Enumerator(_items, Count); 
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public struct Enumerator : IEnumerator<T>
        {
            private readonly T[] _items;
            private readonly int _count;
            private int _index;

            public Enumerator(T[] items, int count)
            {
                _items = items;
                _count = count;
                _index = -1;
                Current = default;
            }
            
            public bool MoveNext()
            {
                if (_index >= _count) return false;
                return ++_index < _count;
            }

            public void Reset() => _index = -1;

            public T Current
            {
                get => _items[_index];
                set => _items[_index] = value;
            }

            object IEnumerator.Current => Current;

            public void Dispose() => Reset();
        }
    }
}

