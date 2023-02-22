public class MyQueue {

    public Stack<int> In { get; set; }
    public Stack<int> Out { get; set; }

    public MyQueue()
    {
        In = new Stack<int>();
        Out = new Stack<int>();
    }

    public void Push(int x)
    {
        Reverse(Out, In);
        In.Push(x);
    }
    

    public int Pop()
    {
        Reverse(In, Out);
        return Out.Pop();
    }

    public int Peek()
    {
        Reverse(In, Out);
        return Out.Peek();
    }

    public bool Empty() => In.Count + Out.Count == 0;

    public void Reverse(Stack<int> from, Stack<int> to)
    {
        while(from.Count > 0) 
            to.Push(from.Pop());
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */