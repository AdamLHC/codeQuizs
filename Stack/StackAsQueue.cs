public class StackAsQueue
{
    public StackAsQueue()
    {

    }

    private Stack<int> pushStack = new Stack<int>();
    private Stack<int> popStack = new Stack<int>();

    public void Push(int x)
    {
        while (popStack.TryPop(out int num))
        {
            pushStack.Push(num);
        }
        pushStack.Push(x);
    }

    public int Pop()
    {
        while (pushStack.TryPop(out int num))
        {
            popStack.Push(num);
        }
        return popStack.Pop();
    }

    public int Peek()
    {
        while (pushStack.TryPop(out int num))
        {
            popStack.Push(num);
        }
        return popStack.Peek();
    }

    public bool Empty()
    {
        return !pushStack.TryPeek(out _) && !popStack.TryPeek(out _);
    }
}