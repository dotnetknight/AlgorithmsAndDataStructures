namespace LeetCode.Tests
{
    public static class AssertHelper
    {
        public static void AssertLinkList(int[] expected, ListNode actual)
        {
            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);
            Assert.IsTrue(expected.Length > 0);

            var current = actual;
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsNotNull(current);
                Assert.AreEqual(expected[i], current.val);
                current = current.next;
            }

            Assert.IsNull(current);
        }
    }
}