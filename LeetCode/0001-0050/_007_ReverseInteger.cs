namespace LeetCode._0001_0050
{
    public class _007_ReverseInteger
    {
        // O(n) time | O(1) space

        public int Reverse(int x)
        {
            long reversed = 0;
            while (x != 0)
            {
                reversed = (reversed * 10) + (x % 10);
                x /= 10;

                if (reversed < int.MinValue || reversed > int.MaxValue)
                {
                    return 0;
                }
            }

            return (int)reversed;
        }
    }
}