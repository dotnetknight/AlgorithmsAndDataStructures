namespace DataStructures
{
    public class Stacks
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

        // O(n) time | O(n) space
        public bool BalancedBrackets(string s)
        {
            string openingBrackets = "([{";
            string closingBrackets = ")]}";

            List<char> stack = new();
            Dictionary<char, char> matchingBrackets = new()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];
                if (openingBrackets.IndexOf(letter) != -1)
                {
                    stack.Add(letter);
                }
                else if (closingBrackets.IndexOf(letter) != -1)
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (stack[stack.Count - 1] == matchingBrackets[letter])
                    {
                        stack.RemoveAt(stack.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}