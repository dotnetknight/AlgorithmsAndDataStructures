using LeetCode._0701_0750;

namespace LeetCode.Tests._0701_0750
{
    public class _0705_DesignHashset_Test
    {
        [Test]
        public void DesignHashSet()
        {
            var hashSet = new _0705_DesignHashset();

            hashSet.Add(1);
            hashSet.Add(2);
            Assert.IsTrue(hashSet.Contains(1));
            Assert.IsFalse(hashSet.Contains(3));
            hashSet.Add(2);
            Assert.IsTrue(hashSet.Contains(2));
            hashSet.Remove(2);
            Assert.IsFalse(hashSet.Contains(2));
        }
    }
}