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
            var tree = new TTree<float>();

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
            var tree = new TTree<string>();

            tree.Nodes = new[] {"a", "b", "c", "d", "e", "f", "g", "h"};
            
            Assert.AreEqual("b", tree.GetLeftChild(0));
            Assert.AreEqual("d", tree.GetLeftChild(1));
            Assert.AreEqual("f", tree.GetLeftChild(2));
            Assert.AreEqual("h", tree.GetLeftChild(3));
        }
    }
}