using LeetCode._0851_0900;

namespace LeetCode.Tests._0851_0900
{
    public class _0876_MiddleOfTheLinkedList_Test
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6 })]
        public void MiddleOfTheLinkedList(int[] numbers, int[] expected)
        {
            var head = TestHelper.GenerateList(numbers);

            var solution = new _0876_MiddleOfTheLinkedList();
            var result = solution.MiddleNode(head);
            AssertHelper.AssertLinkList(expected, result);
        }
    }
}