using System;
using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    public class TurboTreeTest
    {
        [Test]
        public void ReturnItensFromTree()
        {
            var tree = new TTree();

            tree.Nodes = new float[] { 16, 44, 28, -9, 0 };
            
            Assert.AreEqual(16, tree.GetValue(0));
            Assert.AreEqual(44, tree.GetValue(1));
            Assert.AreEqual(28, tree.GetValue(2));
            Assert.AreEqual(-9, tree.GetValue(3));
            Assert.AreEqual(0, tree.GetValue(4));
        }

        [Test]
        public void ReturnLeftChild()
        {
            var tree = new TTree();

            tree.Nodes = new float[] {0, 1, 2, 3, 4, 5, 6, 7};
            
            Assert.AreEqual(1, tree.GetLeftChild(0));
            Assert.AreEqual(3, tree.GetLeftChild(1));
            Assert.AreEqual(5, tree.GetLeftChild(2));
            Assert.AreEqual(7, tree.GetLeftChild(3));
        }
        
        [Test]
        public void ReturnRightChild()
        {
            var tree = new TTree();

            tree.Nodes = new float[] {0, 1, 2, 3, 4, 5, 6, 7};
            
            Assert.AreEqual(2, tree.GetRightChild(0));
            Assert.AreEqual(4, tree.GetRightChild(1));
            Assert.AreEqual(6, tree.GetRightChild(2));
            Assert.AreEqual(float.NegativeInfinity, tree.GetRightChild(3));
        }
    }
}