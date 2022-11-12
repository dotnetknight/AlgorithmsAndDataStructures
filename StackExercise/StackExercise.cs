using System.Text;

namespace StackExercise
{
    public class StackExercise
    {
        /*
        // O(n) Time | O(n) space
        public string ReverseString(string str)
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i].ToString());
            }

            StringBuilder reversed = new StringBuilder();
            foreach (var character in stack)
            {
                reversed.Append(character);
            }


            return reversed.ToString();
        }

        */

        // O(n) time | O(1) extra space
        public string ReverseString(char[] s)
        {
            int length = s.Length;

            for (int i = 0; i < length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[length - i - 1];
                s[length - i - 1] = temp;
            }

            return new string(s);
        }
    }
}