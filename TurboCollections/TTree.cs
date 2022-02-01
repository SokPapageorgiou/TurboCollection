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

        public T GetValue(int n)
        {
            return _nodes[n];
        }
    }
}