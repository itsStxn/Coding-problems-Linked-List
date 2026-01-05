using System;

namespace Reverse_Linked_List;

public class Solution {
	public ListNode? ReverseList(ListNode head) {
		ListNode? prev = null, curr = head, next;

		while (curr != null) {
			next = curr.next;
			curr.next = prev;
			prev = curr;
			curr = next;
		}

		return prev;
	}

	public ListNode? ReverseListRecursively(ListNode? head, ListNode? prev = null) {
		if (head == null) return prev;

		ListNode? next = head.next;
		head.next = prev;

		return ReverseListRecursively(next, head);
	}
}
