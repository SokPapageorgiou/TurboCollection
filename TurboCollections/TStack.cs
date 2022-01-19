using System;

namespace TurboCollections
{
    public class TStack<T>
    {
        public TStack() => Console.WriteLine("Hello Turbo!");

        private T[] _items = Array.Empty<T>();

        public T[] Items => _items;

        public int Count { get; set; }
    }
}