using LinkedList;
using DataStructures;

var input = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
var solution = new ReverseLinkedList();
var output = solution.ReverseListRecursive(input);

var index = output;
while (index != null)
{
    Console.WriteLine($"node value:{index.val}");
    index = index.next;
}
