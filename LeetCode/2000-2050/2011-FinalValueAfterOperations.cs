namespace LeetCode._2000_2050
{
    public class _2011_FinalValueAfterOperations
    {
        // O(n) time | O(1) space
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;

            foreach (string operation in operations)
            {
                if (operation.Contains('+'))
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }

            return x;
        }
    }
}