using Add_Two_Numbers;

var task = new Solution();
var l1 = new ListNode(2).Add(4).Add(3);
var l2 = new ListNode(5).Add(6).Add(4);

var result = task.AddTwoNumbers(l1, l2);
Console.WriteLine(result);
