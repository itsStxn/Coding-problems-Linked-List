using System;

namespace Copy_List_with_Random_Pointer;

public class Solution {
	virtual public Node? CopyRandomList(Node head) {
		Node? copy = new(0), curr = head;

		while (curr != null) {
			var next = curr.next;
			curr.next = new(curr.val){
				next = next
			};
			curr = next;
		}

		curr = head;
		while (curr != null) {
			var next = curr.next!;
			if (curr.random != null)
				next.random = curr.random.next;
			curr = next.next;
		}

		curr = head; 
		var currCopy = copy;
		while (curr != null) {
			var next = curr.next!;
			currCopy.next = next;
			currCopy = currCopy.next;

			curr.next = next.next;
			curr = next.next;
		}

		return copy.next;
	}
}
