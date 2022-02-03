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
        private TNode returner;
        
        public void Add(int item)
        {
            if (nodes[_index] == null)
            {
                nodes[_index] = new TNode(item);
                _index = 0;
            }
            else
            {
                MoveForward(item);
                Add(item);
            }
        }

        public TNode Search(int target)
        {
            if (nodes[_index] != null)
            {
                if(nodes[_index].Value == target)
                    returner = nodes[_index];
                
                _index = 0;
            }
            else
            {
                MoveForward(target);
                if (_index <= nodes.Length) Search(target);
            }

            return returner;
        }

        private void MoveForward(int item)
        {
            if (nodes[_index].Value > item)
                _index = GoLeft(_index);

            else _index = GoRight(_index);
        }

        private int GoLeft(int n) => n * 2 + 1;
        private int GoRight(int n) => n * 2 + 2;
        
    }
}

