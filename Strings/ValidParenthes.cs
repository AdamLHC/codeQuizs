public class ValidParentheses
{
    private Stack<char> storage = new();

    public bool IsValid(string s)
    {
        foreach (var p in s)
        {
            switch (p)
            {
                case '[' or '(' or '{':
                    storage.Push(p);
                    break;

                case ')':
                    if (storage.TryPop(out var small) != true || small != '(')
                        return false;
                    break;

                case ']':
                    if (storage.TryPop(out var medium) != true || medium != '[')
                        return false;
                    break;

                case '}':
                    if (storage.TryPop(out var big) != true || big != '{')
                        return false;
                    break;

                default:
                    break;
            }
        }

        if (storage.Count != 0)
            return false;

        return true;
    }
}