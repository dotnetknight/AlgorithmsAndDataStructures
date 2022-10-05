using LeetCode._1251_1300;

namespace LeetCode.Tests._1251_1300
{
    public class _1290_ConvertBinaryNumberInALinkedListToInteger_Test
    {
        [Test]
        [TestCase(new int[] { 1, 0, 1 }, 5)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, 18880)]
        public void ConvertBinaryNumberInALinkedListToInteger(int[] numbers, int expected)
        {
            var solution = new _1290_ConvertBinaryNumberInALinkedListToInteger();
            var convertedToListNode = TestHelper.GenerateList(numbers);
            var result = solution.GetDecimalValue(convertedToListNode);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}