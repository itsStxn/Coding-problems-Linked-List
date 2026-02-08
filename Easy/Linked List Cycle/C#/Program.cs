using Linked_List_Cycle;


var task = new Solution();
var node = new ListNode(-4);
var head = new ListNode([3,2,0]).Add(node);
node.Add(head.next);
var result = task.HasCycle(head);
Console.WriteLine(result);

task = new AlternativeSolution();
node = new ListNode(-4);
head = new ListNode([3,2,0]).Add(node);
node.Add(head.next);
result = task.HasCycle(head);
Console.WriteLine(result);
