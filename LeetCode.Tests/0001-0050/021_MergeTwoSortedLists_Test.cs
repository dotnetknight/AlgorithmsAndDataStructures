using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _021_MergeTwoSortedLists_Test
    {
        [Test]
        [TestCase(new int[] { 1, 3, 5, 7, 9 }, new int[] { 2, 4, 6, 8, 10 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 13 }, new int[] { 2, 4, 6, 8, 10 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13 })]
        [TestCase(new int[] { 1, 3, 5, 7, 9 }, new int[] { 2, 4, 6, 8, 10, 12, 14 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 })]
        public void MergeTwoLists_HasLists_ReturnsMergedList(int[] list1, int[] list2, int[] expected)
        {
            var generatedList1 = TestHelper.GenerateList(list1);
            var generatedList2 = TestHelper.GenerateList(list2);

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(generatedList1, generatedList2);

            AssertHelper.AssertLinkList(expected, result);
        }

        [Test]
        public void MergeTwoLists_NullLists_ReturnsNull()
        {
            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(null, null);

            Assert.That(result, Is.Null);
        }
    }
}