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
        public void AddignAnElementIncreasesCountToOne()
        {
            var list = new TList<float>();
            list.Add(5);
            Assert.AreEqual(1, list.Count);
        }
    }
}

