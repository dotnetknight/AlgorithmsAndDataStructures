using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _005_LongestPalindromicSubstring_Test
    {
        [Test]
        [TestCase("abcdefgfedcba", "abcdefgfedcba")]
        [TestCase("abcdefggfedcba", "abcdefggfedcba")]
        [TestCase("ccc", "ccc")]
        [TestCase("aaaaaaaaaa", "aaaaaaaaaa")]
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("aabccdccbaaeeggee", "aabccdccbaa")]
        [TestCase("eegffgeeaabcdcbaa", "aabcdcbaa")]
        [TestCase("abcdcbbcd", "dcbbcd")]
        [TestCase("abcddcbebcd", "dcbebcd")]
        public void LongestPalindrome_HasString_ReturnsExpectedResult(string str, string expectedString)
        {
            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(str);

            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}