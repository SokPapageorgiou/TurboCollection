using System;
using System.Data;

namespace TurboCollections
{
    public class TTree<T>
    {
        private T[] _nodes;
        
        public T[] Nodes
        {
            get => _nodes;
            set => _nodes = value;
        }

        public T GetLeftChild(int n)
        {
            if (n >= _nodes.Length) 
                return default; 
                
            return _nodes[n * 2 + 1];
        }
        
        public T GetValue(int n)
        {
            return _nodes[n];
        }
    }
}