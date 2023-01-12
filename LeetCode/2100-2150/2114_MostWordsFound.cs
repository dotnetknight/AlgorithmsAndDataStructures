namespace LeetCode._2100_2150
{
    public class _2114_MostWordsFound
    {
        // O(n) time | O(1) space
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;

            foreach (string sentence in sentences)
            {
                int numberOfWords = sentence.Split(" ").Length;
                if (numberOfWords > max)
                {
                    max = numberOfWords;
                }
            }

            return max;
        }
    }
}