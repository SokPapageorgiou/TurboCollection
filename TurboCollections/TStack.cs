using System;

namespace TurboCollections
{
    public class TStack<T>
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
            
            if(Count > _items.Length) IncreaseBuffer();

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

    }
}