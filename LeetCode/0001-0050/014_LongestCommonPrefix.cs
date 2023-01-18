namespace LeetCode._0001_0050
{
    public class _014_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0)
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }
    }
}