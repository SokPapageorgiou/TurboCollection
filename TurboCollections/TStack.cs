using System;

namespace TurboCollections
{
    public class TStack<T>
    {
        public TStack() => Console.WriteLine("Hello Turbo!");

        private T[] _items = Array.Empty<T>();

        public T[] Items => _items;

        public int Count { get; set; }

        public void IncreaseBuffer()
        {
            var temp = new T[_items.Length + 4];

            for (int i = 0; i < _items.Length; i++)
            {
                temp[i] = _items[i];
            }

            _items = temp;
        }
    }
}