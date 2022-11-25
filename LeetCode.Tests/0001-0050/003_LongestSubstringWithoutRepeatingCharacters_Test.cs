using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _003_LongestSubstringWithoutRepeatingCharacters_Test
    {
        [Test]
        public void LongestSubstringWithoutRepeatingCharacters_StringIsEmpty_ReturnsZero()
        {
            var solution = new _003_Longest_Substring_Without_Repeating_Characters();
            var result = solution.LengthOfLongestSubstring("");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void LongestSubstringWithoutRepeatingCharacters_HasWhiteSpace_ReturnsOne()
        {
            var solution = new _003_Longest_Substring_Without_Repeating_Characters();
            var result = solution.LengthOfLongestSubstring(" ");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase("abcd", 4)]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", 26)]
        [TestCase("abcdefghijklmnopqrstuvwxyzabcdefghijk  lmnopqrstuvwxyz", 27)]
        public void LongestSubstringWithoutRepeatingCharacters_HasWhiteSpace_ReturnsOne(string str, int expectedLength)
        {
            var solution = new _003_Longest_Substring_Without_Repeating_Characters();
            var result = solution.LengthOfLongestSubstring(str);
            Assert.That(result, Is.EqualTo(expectedLength));
        }
    }
}