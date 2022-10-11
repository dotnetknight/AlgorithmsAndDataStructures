using LeetCode._2100_2150;

namespace LeetCode.Tests._2100_2150
{
    public class _2114_MostWordsFound_Test
    {
        [Test]
        [TestCase(new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }, 6)]
        [TestCase(new string[] { "please wait", "continue to fight", "continue to win" }, 3)]
        [TestCase(new string[] { "whatever it takes", "deshi basara", "supreme" }, 3)]
        public void MostWordsFound(string[] sentences, int maximumNumberOfWords)
        {
            var solution = new _2114_MostWordsFound();
            var result = solution.MostWordsFound(sentences);
            Assert.That(result, Is.EqualTo(maximumNumberOfWords));
        }
    }
}