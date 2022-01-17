using System;
using System.Linq.Expressions;

namespace TurboCollections
{
    public class TList<T>
    {
        public TList() =>  Console.WriteLine("Hello Turbo!");   
        
        private T[] _list = Array.Empty<T>();

        public T[] List => _list;

        public int Count => _list.Length;

        public void Add(T item)
        {
            Array.Resize(ref _list, _list.Length + 1);
            
            _list[^1] = item;
        }

        public T Get(int index) => _list[index];

        public void Clear() => _list = Array.Empty<T>();
    }    
}

