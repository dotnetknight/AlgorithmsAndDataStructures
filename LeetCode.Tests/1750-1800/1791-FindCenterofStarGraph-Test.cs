using LeetCode._1750_1800;

namespace LeetCode.Tests._1750_1800
{
    public class _1791_FindCenterofStarGraph_Test
    {
        [Test]
        public void FindCenterofStarGraph()
        {
            var edges = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 4, 2 } };

            var solution = new _1791_FindCenterofStarGraph();
            var result = solution.FindCenter(edges);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}