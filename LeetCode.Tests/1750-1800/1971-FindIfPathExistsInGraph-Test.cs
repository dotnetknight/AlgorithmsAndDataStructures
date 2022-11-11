using LeetCode._1750_1800;

namespace LeetCode.Tests._1750_1800
{
    public class _1971_FindIfPathExistsInGraph_Test
    {
        [Test]
        public void FindIfPathExistsInGraph()
        {
            var edges = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 0 } };
            int n = 3, source = 0, destination = 2;

            var solution = new _1971_FindIfPathExistsInGraph();
            var result = solution.ValidPath(n, edges, source, destination);
            Assert.That(result, Is.True);
        }
    }
}