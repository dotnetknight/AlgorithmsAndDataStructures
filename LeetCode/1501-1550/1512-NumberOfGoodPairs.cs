namespace LeetCode._1501_1550
{
    public class _1512_NumberOfGoodPairs
    {
        // O(n^2) time | O(1) space
        public int NumIdenticalPairs(int[] nums)
        {
            int numberOfGoodPairs = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                    {
                        numberOfGoodPairs++;
                    }
                }
            }

            return numberOfGoodPairs;
        }
    }
}