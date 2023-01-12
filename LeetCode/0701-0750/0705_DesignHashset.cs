namespace LeetCode._0701_0750
{
    public class _0705_DesignHashset
    {
        private bool[] arr = new bool[1000001];

        public _0705_DesignHashset()
        {
        }

        public void Add(int key)
        {
            arr[key] = true;
        }

        public void Remove(int key)
        {
            if (Contains(key)) arr[key] = false;
        }

        public bool Contains(int key)
        {
            return arr[key];
        }
    }
}
