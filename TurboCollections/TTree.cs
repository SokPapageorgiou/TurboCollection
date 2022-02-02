using System;
using System.Collections.Generic;
using System.Data;

namespace TurboCollections
{

    public class TNode
    {
        public int Value { get; set; }

        public TNode(int value)
        {
            Value = value;
        }
    }
    
    public class TTree
    {
        public TNode[] nodes = new TNode[16];

        private int _index;
        
        public void Add(int item)
        {
            if (nodes[_index] == null)
            {
                nodes[_index] = new TNode(item);
                _index = 0;
            }
            else
            {
                if (nodes[_index].Value > item)
                    _index = _index * 2 + 1;
                
                else _index = _index * 2 + 2;
                
                Add(item);
            }
        }
    }
}

