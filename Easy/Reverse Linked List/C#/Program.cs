using Reverse_Linked_List;

var task = new Solution();
var node = new ListNode([0,1,2,3,4]);
var result = task.ReverseList(node);
Console.WriteLine($"iteratively: {result}");

task = new Solution();
node = new ListNode([0,1,2,3,4]);
result = task.ReverseList(node);
Console.WriteLine($"recursively: {result}");
