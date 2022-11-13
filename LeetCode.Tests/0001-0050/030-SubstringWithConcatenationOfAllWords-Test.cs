using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _030_SubstringWithConcatenationOfAllWords_Test
    {
        static readonly object[] FindSubstringTestCaseData =
            {
                new object[] { "barfoothefoobarman",  new string[] { "foo", "bar" }, new int[] { 0, 9 } },
                new object[] { "barfoothefoobarman",  new string[] { "foo", "bar", "yeh" }, Array.Empty<int>() },
                new object[] { "barfoothefoobarman", Array.Empty<string>(), Array.Empty<int>() },
                new object[] { "aaaaa", new string[] { "a" }, new int[] { 0, 1, 2, 3, 4 } },
                new object[] { "barfoo", new string[] { "foo", "bar", "the" }, Array.Empty<int>() },
                new object[] { "wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "good" }, new int[] { 8 } }
            };

        [Test]
        [TestCaseSource(nameof(FindSubstringTestCaseData))]
        public void FindSubstring_SubStringTest_MatchExpectedResults(string str, string[] words, int[] expectedResult)
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring(str, words);

            AssertHelper.AssertList(expectedResult, result);
        }
    }
}