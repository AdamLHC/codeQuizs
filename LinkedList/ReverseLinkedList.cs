using DataStructures;

namespace LinkedList;

public class ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        var lookup = new Stack<int>();
        var index = head;
        while (index != null)
        {
            lookup.Push(index.val);
            index = index.next;
        }

        if (lookup.Count < 2)
        {
            return head;
        }
        ListNode ans = new ListNode(lookup.Pop());
        index = ans;
        while (lookup.TryPop(out int val))
        {
            index.next = new ListNode(val);
            index = index.next;
        }

        return ans;
    }

    public ListNode ReverseListFaster(ListNode head)
    {
        ListNode next = null;
        ListNode prev = null;

        while (head != null)
        {
            next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }

    public ListNode ReverseListRecursive(ListNode head) => ReverseWalk(head);

    private ListNode? ReverseWalk(ListNode? current, ListNode? previous = null)
    {
        if (current is null)
        {
            return previous;
        }
        var next = current.next;
        current.next = previous;
        return ReverseWalk(next, current);
    }
}