namespace LeetCode._1750_1800
{
    public class _1971_FindIfPathExistsInGraph
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            for (int i = 0; i < n; i++)
            {
                if (edges[i][source] == destination || edges[source][i] == destination)
                {
                    return true;
                }
            }

            return false;
        }
    }
}