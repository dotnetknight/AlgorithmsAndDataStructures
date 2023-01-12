using System.Text;

namespace LeetCode._1101_1150
{
    public class _1108_DefangingAnIPAddress
    {
        // O(n) time | O(n) space
        public string DefangIPaddr(string address)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < address.Length; i++)
            {
                stringBuilder.Append(address[i] != '.' ? address[i] : "[.]");
            }
            return stringBuilder.ToString();
        }
    }
}
