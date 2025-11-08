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

public class ListNode {
	public int val;
	public ListNode? next;
	public ListNode(int val=0, ListNode? next =null) {
		this.val = val;
		this.next = next;
	}
	public ListNode Add(int node) {
		next = new ListNode(node);
		return next;
	}
	public override string ToString() {
		var output = new List<int>();
		var iter = this;

		while (iter != null) {
			output.Add(iter.val);
			iter = iter.next;
		}

		return string.Join(", ", output);
	}
}
