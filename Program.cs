using DataStructures;
using LinkedList;

var solution = new MiddleOfLinkedList();
var input = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
var output = solution.FindMiddleNode(input);
Console.WriteLine($"output: {output.val}");