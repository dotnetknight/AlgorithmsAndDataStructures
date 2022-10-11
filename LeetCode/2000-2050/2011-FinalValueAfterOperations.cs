namespace LeetCode._2000_2050
{
    public class _2011_FinalValueAfterOperations
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int X = 0;

            foreach (string operation in operations)
            {
                if (operation.Contains('+'))
                {
                    X++;
                }
                else
                {
                    X--;
                }
            }

            return X;
        }
    }
}