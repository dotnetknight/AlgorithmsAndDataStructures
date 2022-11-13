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

        public static void AssertList<T>(T[] expected, IList<T> actual)
        {
            Assert.AreEqual(expected.Length, actual.Count, message: "length is not match");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], message: $"i {i} is not match");
            }
        }

        public static void AssertList<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count, message: "length is not match");

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count, message: $"row {i} length is not match");
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j], message: $"i {i}, j {j} is not match");
                }
            }
        }
    }
}