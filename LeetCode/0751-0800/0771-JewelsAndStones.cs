namespace LeetCode._0751_0800
{
    public class _0771_JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var hashMap = new Dictionary<char, int>();
            int stonesThatAreAlsoJewels = 0;

            foreach (var character in jewels)
            {
                hashMap.Add(character, 0);
            }

            foreach (var character in stones)
            {
                if (hashMap.ContainsKey(character))
                {
                    stonesThatAreAlsoJewels++;
                }
            }

            return stonesThatAreAlsoJewels;
        }
    }
}