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

        [Test]
        public void ReplacesThirdElement()
        {
            var temp = new TList<float>();
            
            temp.Add(123);
            temp.Add(1000);
            temp.Add(82);
            temp.Add(50);

            temp.Set(2, 666);
            
            Assert.AreEqual(666, temp.Get(2));
        }

        [Test]
        public void RemovesSecondElement()
        {
            var temp = new TList<float>();
            
            temp.Add(123);
            temp.Add(1000);
            temp.Add(82);
            temp.Add(50);

            temp.RemoveAt(1);
            
            Assert.AreNotEqual(1000, temp.Get(1));
            Assert.AreEqual(82, temp.Get(1));
        }

        [Test]
        public void CheckIfContainsANumber()
        {
            var temp = new TList<float>();
            
            temp.Add(123);
            temp.Add(1000);
            temp.Add(82);
            temp.Add(50);
            
            Assert.True(temp.Contains(50));
            Assert.False(temp.Contains(45));
        }

        [Test]
        public void ReturnNumberByIndex()
        {
            var temp = new TList<float>();
            
            temp.Add(123);
            temp.Add(1000);
            temp.Add(82);
            temp.Add(50);
            
            Assert.AreEqual(0, temp.IndexOf(123));
            Assert.AreEqual(3, temp.IndexOf(50));
        }

        [Test]
        public void RemoveSecondNumberFromList()
        {
            var temp = new TList<float>();
            
            temp.Add(123);
            temp.Add(1000);
            temp.Add(82);
            temp.Add(50);
            
            temp.Remove(1000);
            
            Assert.AreEqual(82, temp.Items[1]);
            Assert.AreEqual(50, temp.Items[2]);
        }
    }
}

