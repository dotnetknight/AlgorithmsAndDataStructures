namespace LeetCode
{
    //https://leetcode.com/submissions/detail/814671334/
    public class _001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var valuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (valuePairs.ContainsKey(nums[i]))
                {
                    return new int[] { valuePairs[nums[i]], i };
                }
                else
                {
                    valuePairs[target - nums[i]] = i;
                }
            }

            return Array.Empty<int>();
        }
    }
}