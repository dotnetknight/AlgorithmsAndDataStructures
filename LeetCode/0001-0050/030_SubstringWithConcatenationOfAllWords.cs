namespace LeetCode._0001_0050
{
    public class _030_SubstringWithConcatenationOfAllWords
    {
        // O(n*m) time |  O(n+m) space.
        public IList<int> FindSubstring(string s, string[] words)
        {
            var result = new List<int>();
            var wordsLenght = words.Length;
            var sLenght = s.Length;

            if (sLenght == 0 || wordsLenght == 0)
            {
                return result;
            }

            var wordLenght = words[0].Length;
            var concatLenght = wordsLenght * wordLenght;

            if (concatLenght > sLenght)
            {
                return result;
            }

            var wordsMap = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordsMap.ContainsKey(word))
                {
                    wordsMap[word]++;
                }
                else
                {
                    wordsMap[word] = 1;
                }
            }
            IDictionary<string, int> used;

            int i, j;
            for (i = 0; i <= sLenght - concatLenght; i++)
            {
                used = new Dictionary<string, int>(wordsMap);

                for (j = i; j <= sLenght - wordLenght; j += wordLenght)
                {
                    string? subString = s.Substring(j, wordLenght);
                    if (used.TryGetValue(subString, out int count))
                    {
                        if (count == 0) { break; }
                        used[subString]--;
                    }
                    else
                    {
                        break;
                    }
                }

                bool allUsed = true;
                foreach (var pair in used)
                {
                    if (pair.Value > 0) { allUsed = false; break; }
                }

                if (allUsed)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}