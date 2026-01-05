using System;

namespace Reorder_List;

public class Solution {
	public void ReorderList(ListNode head) {
		ListNode slow = head, fast = head;

		while (fast != null && fast.next != null) {
			slow = slow.next!;
			fast = fast.next.next!;
		}

		ListNode? first = head, second = ReverseList(slow)!;
		while (second != null) {
			ListNode? temp1 = first.next;
			ListNode? temp2 = second.next;

			first.next = second;
			second.next = temp1;

			first = temp1!;
			second = temp2;
		}

	}

	private ListNode? ReverseList(ListNode head) {
		ListNode? prev = null,  curr = head.next;
		head.next = null;

		while (curr != null) {
			var next = curr.next;
			curr.next = prev;
			prev = curr;
			curr = next;
		}

		return prev;
	}
}
