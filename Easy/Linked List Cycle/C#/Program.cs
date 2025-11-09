using Linked_List_Cycle;

var task = new Solution();

var node = new ListNode(-4);
var head = new ListNode(3)
.Add(2).Add(0).Add(node);
node.Add(head.next);

var result = task.HasCycle(head);
Console.WriteLine(result);
