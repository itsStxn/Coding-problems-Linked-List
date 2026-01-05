using System;

namespace Remove_Nth_Node_From_End_of_List;

public class Solution {
	public ListNode? RemoveNthFromEnd(ListNode? head, int n) {
		head = new(0, head);
		ListNode? slow = head, fast = head;

		for (int i = 0; i <= n; i++) {
			fast = fast.next!;
		}

		while (fast != null) {
			slow = slow.next!;
			fast = fast.next;
		}

		slow.next = slow.next?.next;

		return head.next;
	}
}
