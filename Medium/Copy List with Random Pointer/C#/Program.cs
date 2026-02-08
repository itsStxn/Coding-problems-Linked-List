using Copy_List_with_Random_Pointer;

var task = new Solution();
var head = new Node([7,13,11,10,1]);
head.next!.random = head;
head.next.next!.random = head.next.next!.next!.next;
head.next.next.next.random = head.next.next;
head.next.next.next.next!.random = head;
var res = task.CopyRandomList(head);
Console.WriteLine(res);

task = new AlternativeSolution();
head = new Node([7,13,11,10,1]);
head.next!.random = head;
head.next.next!.random = head.next.next!.next!.next;
head.next.next.next.random = head.next.next;
head.next.next.next.next!.random = head;
res = task.CopyRandomList(head);
Console.WriteLine(res);
