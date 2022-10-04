using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _004_MedianOfTwoSortedArrays_Test
    {
        [Test]
        [TestCase(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, new int[] { 1 }, 3.5)]
        public void MedianofTwoSortedArraysTest(int[] nums1, int[] nums2, double expected)
        {
            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}