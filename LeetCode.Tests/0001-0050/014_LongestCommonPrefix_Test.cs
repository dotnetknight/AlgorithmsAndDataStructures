using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _014_LongestCommonPrefix_Test
    {
        [Test]
        [TestCase(new string[0], "")]
        [TestCase(new string[1] { "abc" }, "abc")]
        [TestCase(new string[2] { "aa", "a" }, "a")]
        [TestCase(new string[2] { "a", "aa" }, "a")]
        [TestCase(new string[3] { "abcd", "abc", "abd" }, "ab")]
        [TestCase(new string[3] { "abc", "abd", "bcd" }, "")]
        public void LongestCommonPrefix(string[] strs, string expected)
        {
            var solution = new _014_LongestCommonPrefix();
            var result = solution.LongestCommonPrefix(strs);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}