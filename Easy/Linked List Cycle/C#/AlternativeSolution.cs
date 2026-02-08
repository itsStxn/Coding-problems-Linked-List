using System;

namespace Linked_List_Cycle;

public class AlternativeSolution : Solution {
	override public bool HasCycle(ListNode head) {
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
