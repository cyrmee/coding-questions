class MinStack
{
    public Node? head;

    public void Push(int val)
    {
        if (head == null)
            head = new Node(val, null, val);
        else
            head = new Node(val, head, Math.Min(val, head.minimum));
    }

    public void Pop()
    {
        head = head.next;
    }

    public int Top() => head.value;

    public int GetMin() => head.minimum;
}

public class Node
{
    public int value { get; set; }
    public Node? next { get; set; }
    public int minimum { get; set; }

    public Node(int value, Node next, int minimum)
    {
        this.value = value;
        this.next = next;
        this.minimum = minimum;
    }
}