namespace LeetCode.Tests._1451_1500
{
    public class _1474_DeleteNNodesAfterMNodesOfALinkedList_Test
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, 2, 3, new int[] { 1, 2, 6, 7, 11, 12 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 1, 3, new int[] { 1, 5, 9 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 3, 1, new int[] { 1, 2, 3, 5, 6, 7, 9, 10, 11 })]
        [TestCase(new int[] { 9, 3, 7, 7, 9, 10, 8, 2 }, 1, 2, new int[] { 9, 7, 8 })]
        public void DeleteNNodesAfterMNodesOfALinkedList(int[] numbers, int m, int n, int[] expected)
        {
            var head = TestHelper.GenerateList(numbers);

            var solution = new _1474_DeleteNNodesAfterMNodesOfALinkedList();
            var result = solution.DeleteNodes(head, m, n);
            AssertHelper.AssertLinkList(expected, result);
        }
    }
}