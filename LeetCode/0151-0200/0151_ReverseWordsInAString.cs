namespace LeetCode._0151_0200
{
    public class _0151_ReverseWordsInAString
    {
        // O(n) time | O(n) space
        public string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return string.Empty;
            }

            var stringToReverse = s.Trim().Split(' ');
            var finalString = string.Empty;

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                if (stringToReverse[i] != "")
                {
                    finalString = string.Join(" ", finalString, stringToReverse[i]);
                }
            }

            return finalString.Trim();
        }
    }
}
