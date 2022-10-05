using LeetCode._0201_0250;

namespace LeetCode.Tests._0201_0250
{
    public class _0206_ReverseLinkedList_Test
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        public void ReverseList(int[] numbers, int[] expected)
        {
            var head = TestHelper.GenerateList(numbers);

            var solution = new _0206_ReverseLinkedList();
            var result = solution.ReverseList(head);
            AssertHelper.AssertLinkList(expected, result);
        }
    }
}