namespace LeetCode._0001_0050
{
    public class _005_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
            {
                return s;
            }

            int[] currentLongest = { 0, 1 };
            for (int i = 1; i < s.Length; i++)
            {
                int[] odd = GetLongestPalindromeFrom(s, i - 1, i + 1);
                int[] even = GetLongestPalindromeFrom(s, i - 1, i);
                int[] longest = odd[1] - odd[0] > even[1] - even[0] ? odd : even;

                currentLongest = currentLongest[1] - currentLongest[0] >
                longest[1] - longest[0] ? currentLongest : longest;
            }

            return s.Substring(currentLongest[0], currentLongest[1] - currentLongest[0]);
        }

        private static int[] GetLongestPalindromeFrom(string str, int leftIdx, int rightIdx)
        {
            while (leftIdx >= 0 && rightIdx < str.Length)
            {
                if (str[leftIdx] != str[rightIdx])
                {
                    break;
                }

                leftIdx--;
                rightIdx++;
            }

            return new int[] { leftIdx + 1, rightIdx };
        }
    }
}
