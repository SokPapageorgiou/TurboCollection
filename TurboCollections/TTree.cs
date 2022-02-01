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
            int index = n * 2 + 1;
            
            if (index >= _nodes.Length) 
                return default!; 
                
            return _nodes[index];
        }
        
        public T GetRightChild(int n)
        {
            int index = n * 2 + 2;
            
            if (index >= _nodes.Length) 
                return default!; 
                
            return _nodes[index];
        }
        
        public T GetValue(int n)
        {
            return _nodes[n];
        }
    }
}