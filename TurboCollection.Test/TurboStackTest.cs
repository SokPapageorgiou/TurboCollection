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
    }
}