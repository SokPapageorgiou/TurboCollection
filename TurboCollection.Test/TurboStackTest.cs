using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    public class TurboStackTest
    {
        public class Buffer
        {
            [Test]
            public void InitialBufferLenghtZero()
            {
                var stack = new TStack<int>();
                
                Assert.Zero(stack.Count);
            }

            [Test]
            public void IncreaseBufferOnce()
            {
                var stack = new TStack<int>();
                
                stack.IncreaseBuffer();
                
                Assert.AreEqual(4, stack.Items.Length);
            }
            
            public void IncreaseBufferFiveTimes()
            {
                var stack = new TStack<int>();
                
                stack.IncreaseBuffer();
                stack.IncreaseBuffer();
                stack.IncreaseBuffer();
                stack.IncreaseBuffer();
                stack.IncreaseBuffer();
                
                Assert.AreEqual(20, stack.Items.Length);
            }
        }

        public class Count
        {
            [Test]
            public void InitiateCountZero()
            {
                var stack = new TStack<float>();
                
                Assert.Zero(stack.Count);
            }
        }

        public class Push
        {
            [Test]
            public void AddOneItem()
            {
                var stack = new TStack<float>();

                stack.Push(10);
                
                Assert.AreEqual(10, stack.Items[0]);
                Assert.AreEqual(1, stack.Count);
            }

            [Test]
            public void AddFiveItens()
            {
                var stack = new TStack<float>();

                stack.Push(666);
                stack.Push(555);
                stack.Push(444);
                stack.Push(333);
                stack.Push(222);
                
                Assert.AreEqual(666, stack.Items[0]);
                Assert.AreEqual(555, stack.Items[1]);
                Assert.AreEqual(444, stack.Items[2]);
                Assert.AreEqual(333, stack.Items[3]);
                Assert.AreEqual(222, stack.Items[4]);
                Assert.AreEqual(5, stack.Count);
            }
        }

        public class Peak
        {
            [Test]
            public void PeakLast()
            {
                var stack = new TStack<float>();

                stack.Push(666);
                stack.Push(555);
                stack.Push(444);
                stack.Push(333);
                stack.Push(222);
                
                Assert.AreEqual(222, stack.Peak());
            }
        }

        public class Pop
        {
            [Test]
            public void GetLastItemAndRemoveFromStack()
            {
                var stack = new TStack<float>();

                stack.Push(666);
                stack.Push(555);
                stack.Push(444);
                stack.Push(333);
                stack.Push(222);

                var temp = stack.Pop();
                
                Assert.AreEqual(222, temp);
                Assert.AreEqual(4, stack.Count);
            }
        }
        
        
    }
}