public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            int convertedToken = 0;
            if (int.TryParse(token, out convertedToken))
                stack.Push(convertedToken);
            else
            {
                switch (token)
                {
                    case "+":
                        var x = stack.Pop();
                        var y = stack.Pop();
                        stack.Push(y + x);
                        break;
                    case "-":
                        x = stack.Pop();
                        y = stack.Pop();
                        stack.Push(y - x);
                        break;
                    case "*":
                        x = stack.Pop();
                        y = stack.Pop();
                        stack.Push(y * x);
                        break;
                    case "/":
                        x = stack.Pop();
                        y = stack.Pop();
                        stack.Push(y / x);
                        break;
                }
            }
        }
        return stack.Pop();
    }
}