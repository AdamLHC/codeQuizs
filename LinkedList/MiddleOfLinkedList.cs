using DataStructures;

namespace LinkedList;

public class MiddleOfLinkedList
{
    public ListNode FindMiddleNodeFastSlow(ListNode head)
    {
        ListNode? fast, slow;
        fast = slow = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow?.next;
        }

        return slow;
    }


    public ListNode FindMiddleNode(ListNode head)
    {
        FindLength(head, 1);
        return output;
    }

    private ListNode output;

    private int FindLength(ListNode? node, int index)
    {
        if (node == null)
        {
            return index;
        }

        var length = FindLength(node.next, index + 1);
        int mid = length % 2 == 0 ? length / 2 : (length / 2) + 1;
        if (index == mid)
        {
            output = node;
        }
        return length;
    }
}