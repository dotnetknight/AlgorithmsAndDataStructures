namespace LeetCode._0001_0050
{
    //https://leetcode.com/submissions/detail/811031876/
    public class _004_MedianOfTwoSortedArrays
    {
        // O(nlog(n)) time | O(n) space
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = new List<int>(nums1);
            result.AddRange(nums2);
            result.Sort();

            var resultCount = result.Count;
            var l = (int)Math.Floor((decimal)(resultCount / 2));

            if (resultCount % 2 != 0)
            {
                return result[l];
            }
            else
            {
                return (double)(result[l - 1] + result[l]) / 2;
            }
        }
    }
}