using System;

namespace Linked_List_Cycle;

public class Solution {
	public bool HasCycle(ListNode head) {
		ListNode? slow = head, fast = head;

		while (fast != null && fast.next != null) {
			slow = slow.next;
			fast = fast.next.next;
			if (slow == fast) return true;
		}

		return false;
	}
	public bool HasCycleDisruptive(ListNode head) {
		ListNode? marker = new(), curr = head.next;

		while (curr != null) {
			if (curr == marker) return true;
			var next = curr.next;
			curr.next = marker;
			curr = next;
		}

		return false;
	}
}

