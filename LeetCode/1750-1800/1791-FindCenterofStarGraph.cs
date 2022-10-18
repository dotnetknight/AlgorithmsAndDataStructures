namespace LeetCode._1750_1800
{
    public class _1791_FindCenterofStarGraph
    {
        public int FindCenter(int[][] edges)
        {
            var oneDimentionalArrayLenght = edges.Length / 2;

            List<int> zeroIndexedElements = new();
            zeroIndexedElements.Add(edges[0][0]);
            bool containsValue = false;

            for (int i = 1; i < oneDimentionalArrayLenght; i++)
            {
                if (zeroIndexedElements.Contains(edges[i][0]))
                {
                    return edges[i][0];
                }
                else
                {
                    zeroIndexedElements.Add(edges[i][0]);
                }
            }

            if (!containsValue)
            {
                if (edges[0][1] == edges[1][1])
                {
                    return edges[0][1];
                }
                else if (edges[0][1] == edges[2][1])
                {
                    return edges[0][1];
                }
                else
                {
                    return edges[1][1];
                }
            }

            return 0;
        }
    }
}