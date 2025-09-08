using DataStructures;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var slowHead = head;
        var fastHead = head.next;

        while (fastHead != slowHead)
        {
            fastHead = fastHead?.next?.next;
            slowHead = slowHead?.next;
            if (slowHead == null || fastHead == null)
            {
                return false;
            }
        }
        return true;
    }
}