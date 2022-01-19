using System;
using System.Collections;
using System.Collections.Generic;

namespace TurboCollections
{
    public class TStack<T> : IEnumerable<T>
    {
        public TStack() => Console.WriteLine("Hello Turbo!");

        private T[] _items = Array.Empty<T>();

        public T[] Items => _items;

        public int Count { get; private set; }

        public void IncreaseBuffer()
        {
            var temp = new T[_items.Length + 4];

            for (int i = 0; i < _items.Length; i++)
            {
                temp[i] = _items[i];
            }

            _items = temp;
        }

        public void Push(T value)
        {
            Count++;

            if (Count > _items.Length) IncreaseBuffer();

            _items[Count - 1] = value;
        }

        public T Peak() => _items[Count - 1];

        public T Pop()
        {
            var result = _items[--Count];
            _items[Count] = default;
            return result;
        }

        public void Clear()
        {
            Count -= Count;
            _items = Array.Empty<T>();
        }

        public TList<T>.Enumerator GetEnumerator()
        {
            return new TList<T>.Enumerator(_items, Count);
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