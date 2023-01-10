namespace LeetCode._0001_0050
{
    public class _013_RomanToInteger
    {
        // O(n) time | O(1) space
        public int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int current = map[s[i]];
                if (i + 1 < s.Length)
                {
                    int next = map[s[i + 1]];
                    if (current < next)
                    {
                        total += next - current;
                        i++;
                        continue;
                    }
                }
                total += current;
            }

            return total;
        }
    }
}