namespace LeetCode._0001_0050
{
    public class _008_StringToInteger_ATOI
    {
        // O(n) time | O(1) space
        public int MyAtoi(string s)
        {
            int i = 0, sign = 1, number = 0;

            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            if (i < s.Length && (s[i] == '-' || s[i] == '+')) sign = s[i++] == '-' ? -1 : 1;

            while (i < s.Length && char.IsDigit(s[i]))
            {
                if (number > int.MaxValue / 10 || (number == int.MaxValue / 10 && s[i] - '0' > int.MaxValue % 10))
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }

                number = number * 10 + s[i++] - '0';
            }

            return number * sign;
        }
    }
}
