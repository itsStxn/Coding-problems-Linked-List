using System;

namespace Linked_List_Cycle;

public class Solution {
	virtual public bool HasCycle(ListNode head) {
		ListNode? slow = head, fast = head;

		while (fast != null && fast.next != null) {
			slow = slow.next;
			fast = fast.next.next;
			if (slow == fast) return true;
		}

		return false;
	}
}

