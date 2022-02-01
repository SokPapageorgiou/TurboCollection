using System;
using System.Collections.Generic;
using System.Data;

namespace TurboCollections
{
    public class TTree 
    {
        private float[] _nodes;
        
        public float[] Nodes
        {
            get => _nodes;
            set => _nodes = value;
        }

        public float GetLeftChild(int n)
        {
            int index = n * 2 + 1;
            
            if (index >= _nodes.Length) 
                return default!; 
                
            return _nodes[index];
        }
        
        public float GetRightChild(int n)
        {
            int index = n * 2 + 2;
            
            if (index >= _nodes.Length) 
                return float.NegativeInfinity; 
                
            return _nodes[index];
        }
        
        public float GetValue(int n)
        {
            return _nodes[n];
        }

        // public float BinarySearch(float item)
        // {
        //     int n = 0;
        //
        //     if (item == _nodes[n]) return item;
        //     if(item(_nodes[n])){}
        // }

    }
}