using System;

namespace Reverse_Linked_List;

public class Solution {
	virtual public ListNode? ReverseList(ListNode head) {
		ListNode? prev = null, curr = head, next;

		while (curr != null) {
			next = curr.next;
			curr.next = prev;
			prev = curr;
			curr = next;
		}

		return prev;
	}
}
