public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch == '(' || ch == '{' || ch == '[')
                stack.Push(ch);
            else if (stack.Count > 0)
            {
                if (stack.Peek() == '{' && ch == '}')
                    stack.Pop();
                else if (stack.Peek() == '(' && ch == ')')
                    stack.Pop();
                else if (stack.Peek() == '[' && ch == ']')
                    stack.Pop();
                else return false;
            }
            else if (ch == ')' || ch == '}' || ch == ']')
                stack.Push(ch);
        }

        return (stack.Count() == 0);
    }
}