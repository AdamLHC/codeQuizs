using DataStructures;

public static class MergeTwoLists
{
    public static ListNode Merge(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }

        var p1 = list1;
        var p2 = list2;
        ListNode ans = new ListNode();
        var p_current = ans;

        while (p1 != null && p2 != null)
        {
            if (p1.val < p2.val)
            {
                p_current.val = p1.val;
                p_current.next = new ListNode();
                p1 = p1.next;
                p_current = p_current.next;
                continue;
            }
            else
            {
                p_current.val = p2.val;
                p_current.next = new ListNode();
                p2 = p2.next;
                p_current = p_current.next;
                continue;
            }
        }

        if (p1 != null)
        {
            p_current.val = p1.val;
            p_current.next = p1.next;
        }
        if (p2 != null)
        {
            p_current.val = p2.val;
            p_current.next = p2.next;
        }

        return ans;
    }

    public static ListNode? ImprovedMerge(ListNode? list1, ListNode? list2)
    {
        ListNode ans = new ListNode(); //first node is empty
        var pointer = ans;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                pointer.next = list1;
                list1 = list1.next;
            }
            else
            {
                pointer.next = list2;
                list2 = list2.next;
            }
            pointer = pointer.next;
        }
        pointer.next = list1 == null ? list2 : list1;
        return ans.next;
    }
}