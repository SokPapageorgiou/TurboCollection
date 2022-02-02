using System;
using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    public class TurboTreeTest
    {
        [Test]
        public void AddOneNode()
        {
            var tree = new TTree();
            
            tree.Add(5);
            
            Assert.AreEqual(5, tree.nodes[0].Value);
        }
        
        [Test]
        public void AddTwoNodeSecondSmaller()
        {
            var tree = new TTree();
            
            tree.Add(5);
            tree.Add(2);
            
            Assert.AreEqual(2, tree.nodes[1].Value);
        }
        
        [Test]
        public void AddTwoNodeSecondBigger()
        {
            var tree = new TTree();
            
            tree.Add(5);
            tree.Add(10);
            
            Assert.AreEqual(10, tree.nodes[2].Value);
        }
        
        [Test]
        public void AddFiveNodes()
        {
            var tree = new TTree();
            
            tree.Add(5);
            tree.Add(10);
            tree.Add(2);
            tree.Add(77);
            tree.Add(-1);
            
            Assert.AreEqual(5, tree.nodes[0].Value);
            Assert.AreEqual(2, tree.nodes[1].Value);
            Assert.AreEqual(10, tree.nodes[2].Value);
            Assert.AreEqual(-1, tree.nodes[3].Value);
            Assert.AreEqual(77, tree.nodes[6].Value);
        }
    }
}