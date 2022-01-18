using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    public class TurboListTests
    {

        [Test]
        public void NewListIsEmpty()
        {
            var list = new TList<int>();
            Assert.Zero(list.Count);
        }

        [Test]
        public void AddingAnElementIncreasesCountToOne()
        {
            var list = new TList<float>();
            list.Add(5);
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void AddingAnElementInTheLastPosition()
        {
            var list = new TList<float>();
            list.Add(84);
            Assert.AreEqual(84, list.Items[^1]);
        }

        [Test]
        public void GetNumberFromIndex()
        {
            var temp = new TList<float>();
            
            temp.Add(0);
            temp.Add(1);
            temp.Add(2);
            
            Assert.AreEqual(0, temp.Get(0));
            Assert.AreEqual(1, temp.Get(1));
            Assert.AreEqual(2, temp.Get(2));
        }

        [Test]
        public void ClearList()
        {
            var temp = new TList<float>();
            
            temp.Add(0);
            temp.Add(1);
            temp.Add(2);

            temp.Clear();
            
            Assert.AreEqual(0, temp.Count);
        }
    }
}

