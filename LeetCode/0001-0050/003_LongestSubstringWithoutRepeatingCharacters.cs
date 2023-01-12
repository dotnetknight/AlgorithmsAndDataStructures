namespace LeetCode._0001_0050
{
    public class _003_Longest_Substring_Without_Repeating_Characters
    {
        // O(n) time | O(n) space
        public int LengthOfLongestSubstring(string s)
        {
            if (s == "")
            {
                return 0;
            }

            if (s == " ")
            {
                return 1;
            }

            Dictionary<char, int> lastSeen = new Dictionary<char, int>();
            int[] longest = { 0, 1 };
            int startIdx = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];
                if (lastSeen.ContainsKey(letter))
                {
                    startIdx = Math.Max(startIdx, lastSeen[letter] + 1);
                }

                if (longest[1] - longest[0] < i + 1 - startIdx)
                {
                    longest = new int[] { startIdx, i + 1 };
                }

                lastSeen[letter] = i;
            }

            string result = s.Substring(longest[0], longest[1] - longest[0]);
            return result.Length;
        }
    }
}