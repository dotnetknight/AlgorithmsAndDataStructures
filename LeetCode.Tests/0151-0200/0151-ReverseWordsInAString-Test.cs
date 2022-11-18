using LeetCode._0151_0200;
using System.Collections;

namespace LeetCode.Tests._0151_0200
{
    public class ReverseWordsInAStrTestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { string.Empty, string.Empty };
            yield return new object[] { "The Dark Knight", "Knight Dark The" };
            yield return new object[] { "the sky is blue", "blue is sky the" };
            yield return new object[] { "  hello world!  ", "world! hello" };
            yield return new object[] { "a good   developer", "developer good a" };
        }
    }

    public class _0151_ReverseWordsInAString_Test
    {
        [Test]
        [TestCaseSource(typeof(ReverseWordsInAStrTestCaseData))]
        public void ReverseString_HasStringToReverse_ReturnsReversedString(string words, string reversed)
        {
            var solution = new _0151_ReverseWordsInAString();
            var reversedString = solution.ReverseWords(words);

            Assert.That(reversedString, Is.EqualTo(reversed));
        }
    }
}
