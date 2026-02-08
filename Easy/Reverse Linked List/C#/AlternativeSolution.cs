using System;

namespace Reverse_Linked_List;

public class AlternativeSolution : Solution {
	override public ListNode? ReverseList(ListNode? head) {
		static ListNode? reverse(ListNode? head, ListNode? prev = null) {
			if (head == null) return prev;

			ListNode? next = head.next;
			head.next = prev;

			return reverse(next, head);
		}

		return reverse(head);
	}
}
