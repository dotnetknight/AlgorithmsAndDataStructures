namespace LeetCode._0051_0100
{
    public class _066_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 1 && digits[0] == 9)
            {
                return new int[] { 1, 0 };
            }

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;

            return newDigits;
        }
    }
}