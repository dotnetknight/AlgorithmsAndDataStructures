namespace LeetCode._0051_0100
{
    public class _070_ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n < 4)
            {
                return n;
            }

            int x1 = 2, x2 = 3, temp;
            for (int i = 4; i <= n; i++)
            {
                temp = x1 + x2;
                x1 = x2;
                x2 = temp;
            }

            return x2;
        }
    }
}