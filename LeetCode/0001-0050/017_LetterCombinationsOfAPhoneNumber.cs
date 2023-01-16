namespace LeetCode._0001_0050
{
    public class _017_LetterCombinationsOfAPhoneNumber
    {
        private static readonly string[] mapping = new string[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            if (!string.IsNullOrWhiteSpace(digits))
            {
                GenerateCombination("", digits, 0, result);
            }
            return result;
        }

        private void GenerateCombination(string combination, string digits, int index, List<string> result)
        {
            if (index == digits.Length)
            {
                result.Add(combination);
                return;
            }

            string letters = mapping[digits[index] - '0'];
            for (int i = 0; i < letters.Length; i++)
            {
                GenerateCombination(combination + letters[i], digits, index + 1, result);
            }
        }
    }
}